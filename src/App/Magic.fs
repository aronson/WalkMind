/// Encapsulate all reads to foreign memory in Cogmind within this helper module
module Magic

open System.Diagnostics
open System.Runtime.InteropServices
open System
open FsToolkit.ErrorHandling
open Domain

/// Used to set focus to cogmind for input
[<DllImport("user32.dll")>]
extern int SetForegroundWindow(int hwnd)

/// Used to ensure we aren't sending inputs when Cogmind doesn't have focus
[<DllImport("user32")>]
extern int GetForegroundWindow()

let opt = OptionBuilder()

// https://stackoverflow.com/q/33882995
let flip f x y = f y x
let curry f a b = f (a, b)
let uncurry f (a, b) = f a b
/// (f:int * int * byte[] * int * byref<int> -> bool)
type MemoryOperation = int -> int -> int -> byte []

[<DllImport("kernel32.dll")>]
extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte [] lpBuffer, int dwSize, int& lpNumberOfBytesRead)

/// Meat and potatoes of .NET interop for spying on Cogmind's memory
let ReadMemory hProcess lpBaseAddress dwSize =
    /// buffer is where the memory we requested will be dumped to
    let mutable buffer = Array.init dwSize byte
    /// this is helper data from the method we must writeback anyways
    let mutable lpNumberOfBytesWritten = 0

    // actually read memory
    ReadProcessMemory(hProcess, lpBaseAddress, buffer, dwSize, &lpNumberOfBytesWritten)
    |> ignore

    // return the memory buffer read from the interop
    buffer

/// Required to get a handle that allows us to spy on memory
[<DllImport("kernel32.dll")>]
extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId)

/// functional version of OpenProcess interop
let openProcess (p: Process) =
    /// magic byte for only reading from the process
    let PROCESS_WM_READ = 0x0010
    OpenProcess(PROCESS_WM_READ, false, p.Id)

/// Required to clean up system resources after spying on Cogmind's memory
[<DllImport("kernel32.dll", SetLastError = true)>]
[<return: MarshalAs(UnmanagedType.Bool)>]
extern bool CloseHandle(IntPtr hObject)

/// This is the IO monad, don't ask
let readMemory<'a>
    (bitConverter: byte [] -> 'a)
    (length: int)
    (memoryOperation: MemoryOperation)
    (memory: int)
    (ptr: IntPtr)
    =
    (memoryOperation ((int) ptr) memory length)
    |> bitConverter

/// Don't ask about this one either, it fixes the shape of the function for us
let bitConverter func =
    func |> curry |> flip <| 0 |> readMemory

let intIO =
    bitConverter BitConverter.ToInt32 4

let booleanIO =
    bitConverter BitConverter.ToBoolean 1

let charIO =
    bitConverter BitConverter.ToChar 1

/// Read a single integer from memory
let readInt = intIO ReadMemory
/// Read a single boolean from memory
let readBoolean = booleanIO ReadMemory
/// Read a single character from memory
let readChar = charIO ReadMemory

/// At runtime, we may encounter 0, 1, or more Cogmind processes. For now we only support one running at a time.
// TODO: Spawn Cogmind process ourselves?
let seekCogmindProcess: Result<Process, string> =
    // A simple search for the cogmind process based on its name
    let cogmindProcessCandidates =
        Process.GetProcessesByName("Cogmind")
    // Ensure there is only a single process to capture, and return it or die trying
    match cogmindProcessCandidates with
    | [||] -> Error "No process found for Cogmind"
    | [| cogmindProcess |] -> Ok cogmindProcess
    | _ -> Error "Multiple processes found for Cogmind"

/// A record type that represents the raw memory Kyzrati provides in -luigiAi mode
type LuigiAi =
    { magic1: int
      magic2: int
      actionReady: int
      mapWidth: int
      mapHeight: int
      depth: int
      mapType: MapType
      tilePointer: int
      mapCursorIndex: int
      playerEntityPointer: int
      machineHackingPointer: int }

/// The first mutually-agreed upon magic number for the LuigiAi structure header
let primaryMagic = 0x64ADFA4C
/// The second mutually-agreed upon magic number for the LuigiAi structure header
let secondaryMagic = 0x79533ED9
// four byte-aligned struct, store all the offsets we'll need later
let (secondaryMagicOffset,
     actionReadyOffset,
     mapWidthOffset,
     mapHeightOffset,
     depthOffset,
     mapTypeOffset,
     mapDataOffset,
     mapCursorOffset,
     playerEntityPointerOffset,
     machineHackingOffset) =
    (4, 8, 12, 16, 20, 24, 28, 32, 36, 40)

/// Very simple record type representing an item on the floor or equipped
type LuigiItem = { item: Item; integrity: int }
let itemIntegrityOffset = 4

/// These records in tile data are player and non-player characters with a set of stats
type LuigiEntity =
    { entity: entity
      integrity: int
      faction: int
      entityActiveState: int
      exposure: int
      energy: int
      matter: int
      heat: int
      corruption: int
      speed: int }

let (entityIntegrityOffset,
     entityFactionOffset,
     entityActiveStateOffset,
     entityExposureOffset,
     entityEnergyOffset,
     entityMatterOffset,
     entityHeatOffset,
     entityCorruptionOffset,
     entitySpeedOffset) =
    (4, 8, 12, 16, 20, 24, 28, 32, 36)

/// These records are the core tile data for what is in Cogmind's current and past field of view
type LuigiTile =
    { col: int
      row: int
      lastAction: int
      cell: cell
      doorOpen: bool
      lastFov: int
      propPointer: int option
      entity: LuigiEntity option
      item: LuigiItem option }

let (lastActionOffset,
     lastFovOffset,
     cellOffset,
     doorOpenOffset,
     propPointerOffset,
     entityPointerOffset,
     itemPointerOffset) =
    (0, 4, 8, 12, 16, 20, 24)

/// An abstraction to ensure that col and row are always passed in the same order when accessing tile data
type AddressCoordinate = AddressCoordinate of (int * int)

/// Encapsulates reads to the Cogmind process's memory as a proper F# OO type
type Magic() =
    /// The single, current running Cogmind process
    let cogmindProcess =
        match seekCogmindProcess with
        | Error message -> raise (Exception message)
        | Ok cogmindProcess -> cogmindProcess

    /// The handle Windows uses to read memory from the Cogmind process after it has been open
    let processHandle = cogmindProcess.Handle

    /// A recursive function that seeks out two 4-byte aligned magic numbers in memory and returns the offset of the
    /// first magic number, which is presumed to be the LuigiAi structure start.
    let rec seekMagicStart offset : Result<int, string> =
        // Terminate if we got past 250 MB as a weak heuristic to limit the search
        let maximumMemorySearchAddress = 0xC89A140

        if (offset >= maximumMemorySearchAddress) then
            Error "magic not found before 250 MiB"
        else
            // Read 4 bytes at some offset into memory
            let value = readInt offset processHandle

            // Check if this byte matches the first magic number
            match value = primaryMagic with
            | true ->
                // Sometimes we find the code pointer instead, we need to learn about regions to fix that
                printfn "Seek found first pointer at %d" offset

                // Read the next integer adjacent to this one
                let nextValue =
                    readInt (offset + secondaryMagicOffset) processHandle

                match (nextValue = secondaryMagic) with
                | true ->
                    printfn "Seek found second pointer at %d" (offset + secondaryMagicOffset)
                    // Can now infer movement value
                    Ok offset
                | false ->
                    printfn "... was code pointer"
                    seekMagicStart (offset + 4)
            // Keep searching 4 bytes forward
            | false -> seekMagicStart (offset + 4)

    /// The location in memory in Cogmind's heap where the LuigiAi structure begins
    let magicPointer =
        match seekMagicStart 4096000 with
        | Error message -> raise (Exception message)
        | Ok pointer -> pointer

    /// Helper function to not open null pointers
    let tryOpenPointer =
        function
        | value when value <> int IntPtr.Zero -> readInt value processHandle |> Some
        | _ -> None

    let unwrapItem pointer : Item = readInt pointer processHandle |> itemId

    let unwrapEntityId pointer : entity =
        readInt pointer processHandle |> enum<entity>

    let unwrapCell pointer : cell =
        readInt pointer processHandle |> enum<cell>

    let tryUnwrapEntity =
        function
        | pointer when pointer <> int IntPtr.Zero ->
            opt {
                let entity = pointer |> unwrapEntityId
                let! integrity = pointer + entityIntegrityOffset |> tryOpenPointer
                let! faction = pointer + entityFactionOffset |> tryOpenPointer

                let! entityActiveState =
                    pointer + entityActiveStateOffset
                    |> tryOpenPointer

                let! exposure = pointer + entityExposureOffset |> tryOpenPointer
                let! energy = pointer + entityEnergyOffset |> tryOpenPointer
                let! matter = pointer + entityMatterOffset |> tryOpenPointer
                let! heat = pointer + entityHeatOffset |> tryOpenPointer
                let! corruption = pointer + entityCorruptionOffset |> tryOpenPointer
                let! speed = pointer + entitySpeedOffset |> tryOpenPointer

                return
                    { entity = entity
                      integrity = integrity
                      faction = faction
                      entityActiveState = entityActiveState
                      exposure = exposure
                      energy = energy
                      matter = matter
                      heat = heat
                      corruption = corruption
                      speed = speed }
            }
        | _ -> None

    member _.actionReadyValue =
        readInt (magicPointer + actionReadyOffset) processHandle

    member _.mapType =
        liftMapType
        <| readInt (magicPointer + mapTypeOffset) processHandle

    member _.mapWidth =
        readInt (magicPointer + mapWidthOffset) processHandle

    member _.mapHeight =
        readInt (magicPointer + mapHeightOffset) processHandle

    member _.startTilePointer =
        readInt (magicPointer + mapDataOffset) processHandle

    member this.tiles =
        List.allPairs [ 0 .. this.mapWidth - 1 ] [
            0 .. this.mapHeight - 1
        ]
        |> List.map (fun (row, col) -> col, row)
        |> List.map AddressCoordinate
        |> List.map (fun coord -> this.tile coord)

    member this.tile
        with get (AddressCoordinate (col, row)) =

            let offset =
                (row * this.mapHeight + col) * 28 // length of struct
                + this.startTilePointer

            let prop =
                readInt (offset + propPointerOffset) processHandle
                |> tryOpenPointer

            let entity =
                readInt (offset + entityPointerOffset) processHandle
                |> tryUnwrapEntity

            let item =
                readInt (offset + itemPointerOffset) processHandle
                |> function
                    | itemOffset when itemOffset <> int IntPtr.Zero ->
                        { item = unwrapItem itemOffset
                          integrity = readInt (itemOffset + 4) processHandle }
                        |> Some
                    | _ -> None

            { col = col
              row = row
              lastAction = readInt offset processHandle
              cell = unwrapCell (offset + cellOffset)
              doorOpen = readBoolean (offset + doorOpenOffset) processHandle
              lastFov = readInt (offset + lastFovOffset) processHandle
              propPointer = prop
              entity = entity
              item = item }

    member _.depth =
        readInt (magicPointer + depthOffset) processHandle

    member _.mapCursorIndex =
        readInt (magicPointer + mapCursorOffset) processHandle

    member this.player =
        let filterCogmindTile tile =
            match tile.entity with
            | Some entity when entity.entity = Domain.entity.Cogmind -> true
            | _ -> false

        this.tiles |> List.find filterCogmindTile

    member _.activateCogmindWindow() =
        SetForegroundWindow(cogmindProcess.MainWindowHandle |> int)
        |> ignore

    member _.isCogmindForegroundWindow() =
        cogmindProcess.MainWindowHandle |> int = GetForegroundWindow()
