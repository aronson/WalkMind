module Magic

open System.Diagnostics
open System.Runtime.InteropServices
open System
open FsToolkit.ErrorHandling
open Domain

/// Used to set focus to cogmind for input
[<DllImport("user32.dll")>]
extern int SetForegroundWindow(int hwnd)

[<DllImport("user32")>]
extern int GetForegroundWindow()

type OptionBuilder() =
    member x.Bind(v, f) = Option.bind f v
    member x.Return v = Some v
    member x.ReturnFrom o = o
    member x.Zero() = None

let opt = OptionBuilder()

// https://stackoverflow.com/q/33882995
let flip f x y = f y x
let curry f a b = f (a, b)
let uncurry f (a, b) = f a b
type MemoryOperation = int -> int -> int -> byte []
//(f:int * int * byte[] * int * byref<int> -> bool)

[<DllImport("kernel32.dll")>]
extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte [] lpBuffer, int dwSize, int& lpNumberOfBytesRead)

let ReadMemory hProcess lpBaseAddress dwSize =
    let mutable buffer = Array.init dwSize byte
    let mutable lpNumberOfBytesWritten = 0

    ReadProcessMemory(hProcess, lpBaseAddress, buffer, dwSize, &lpNumberOfBytesWritten)
    |> ignore

    buffer

[<DllImport("kernel32.dll")>]
extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId)

let openProcess (p: Process) =
    let PROCESS_WM_READ = 0x0010
    OpenProcess(PROCESS_WM_READ, false, p.Id)

[<DllImport("kernel32.dll", SetLastError = true)>]
[<return: MarshalAs(UnmanagedType.Bool)>]
extern bool CloseHandle(IntPtr hObject)

let readMemory<'a>
    (bitConverter: byte [] -> 'a)
    (length: int)
    (memoryOperation: MemoryOperation)
    (memory: int)
    (ptr: IntPtr)
    =
    (memoryOperation ((int) ptr) memory length)
    |> bitConverter


let bitConverter func =
    func |> curry |> flip <| 0 |> readMemory

let intIO =
    bitConverter BitConverter.ToInt32 4

let booleanIO =
    bitConverter BitConverter.ToBoolean 1

let charIO =
    bitConverter BitConverter.ToChar 1

let readInt = intIO ReadMemory
let readBoolean = booleanIO ReadMemory
let readChar = charIO ReadMemory

let seekCogmindProcess: Result<Process, string> =
    let cogmindProcessCandidates =
        Process.GetProcessesByName("Cogmind")

    match cogmindProcessCandidates with
    | [| cogmindProcess |] -> Ok cogmindProcess
    | _ -> Error "Multiple processes found for Cogmind"

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

let primaryMagic = 1689123404
let secondaryMagic = 2035498713
// four byte-aligned struct
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

type LuigiItem = { item: Item; integrity: int }
let itemIntegrityOffset = 4

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

type AddressCoordinate = AddressCoordinate of (int * int)

type MagicResult = Result<LuigiAi * LuigiEntity * LuigiTile list * int, string>

type Magic() =
    let cogmindProcess =
        match seekCogmindProcess with
        | Error message -> raise (Exception message)
        | Ok cogmindProcess -> cogmindProcess

    let processHandle = cogmindProcess.Handle

    let rec seekMagicStart offset : Result<int, string> =
        if (offset >= 210346304) then
            Error "magic not found before 250 MiB"
        else
            let value = readInt offset processHandle

            match value = primaryMagic with
            | true ->
                // Sometimes we find the code pointer instead, we need to learn about regions to fix that
                printfn "Seek found first pointer at %d" offset

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
            | false -> seekMagicStart (offset + 4)

    let magicPointer =
        match seekMagicStart 4096000 with
        | Error message -> raise (Exception message)
        | Ok pointer -> pointer

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
        |> List.map(fun (row, col) -> col, row)
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
