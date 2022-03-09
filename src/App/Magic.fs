module Magic

open System.Diagnostics
open System.Runtime.InteropServices
open System
open FsToolkit.ErrorHandling
open Domain

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

let intIO = bitConverter BitConverter.ToInt32 4
let booleanIO = bitConverter BitConverter.ToBoolean 1
let charIO = bitConverter BitConverter.ToChar 1

let readInt = intIO ReadMemory
let readBoolean = booleanIO ReadMemory
let readChar = charIO ReadMemory

let seekCogmindProcess: Result<Process, string> =
    let cogmindProcessCandidates = Process.GetProcessesByName("Cogmind")

    match cogmindProcessCandidates with
    | [||] -> Error "Cogmind not launched"
    | [| cogmindProcess |] -> Ok cogmindProcess
    | _ -> Error "Multiple processes found for Cogmind"

type LuigiAi =
    { magic1: int
      magic2: int
      actionReady: int
      mapWidth: int
      mapHeight: int
      tilePointer: int
      playerEntityPointer: int }

let primaryMagic = 1689123404
let secondaryMagic = 2035498713
// four byte-aligned struct
let (secondaryMagicOffset, actionReadyOffset, mapWidthOffset, mapHeightOffset, mapDataOffset, playerEntityPointerOffset) =
    (4, 8, 12, 16, 20, 24)

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
    { row: int
      col: int
      lastAction: int
      cell: cell
      lastFov: int
      propPointer: int option
      entity: LuigiEntity option
      item: LuigiItem option }

let (lastActionOffset, cellOffset, lastFovOffset, propPointerOffset, entityPointerOffset, itemPointerOffset) =
    (0, 4, 8, 12, 16, 20)

type AddressCoordinate = AddressCoordinate of (int * int)

type MagicResult = Result<LuigiAi * LuigiEntity * LuigiTile list, string>

let rec seekMagicStart processHandle offset : Result<int, string> =
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
                seekMagicStart processHandle (offset + 4)
        | false -> seekMagicStart processHandle (offset + 4)

let openMagicResult cogmindProcess : MagicResult =
    let processHandle = openProcess cogmindProcess

    let openMagic offset : LuigiAi =
        { magic1 = primaryMagic
          magic2 = secondaryMagic
          actionReady = readInt (offset + actionReadyOffset) processHandle
          mapWidth = readInt (offset + mapWidthOffset) processHandle
          mapHeight = readInt (offset + mapHeightOffset) processHandle
          tilePointer = readInt (offset + mapDataOffset) processHandle
          playerEntityPointer = readInt (offset + playerEntityPointerOffset) processHandle }

    let tryOpenPointer =
        function
        | value when value > 0 -> readInt value processHandle |> Some
        | _ -> None

    let unwrapItem pointer : Item = readInt pointer processHandle |> itemId

    let unwrapEntityId pointer : entity =
        readInt pointer processHandle |> enum<entity>

    let unwrapCell pointer : cell =
        readInt pointer processHandle |> enum<cell>

    let tryUnwrapEntity =
        function
        | pointer when pointer > 0 ->
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

    let tryUnwrapTile pointer (x, y) : Result<LuigiTile, string> =
        opt {
            let prop =
                readInt (pointer + propPointerOffset) processHandle
                |> tryOpenPointer

            let entity =
                readInt (pointer + entityPointerOffset) processHandle
                |> tryUnwrapEntity

            let item =
                readInt (pointer + itemPointerOffset) processHandle
                |> function
                    | itemOffset when itemOffset > 0 ->
                        { item = unwrapItem itemOffset
                          integrity = readInt (itemOffset + 4) processHandle }
                        |> Some
                    | _ -> None

            return
                { row = x
                  col = y
                  lastAction = readInt pointer processHandle
                  cell = unwrapCell (pointer + cellOffset)
                  lastFov = readInt (pointer + lastFovOffset) processHandle
                  propPointer = prop
                  entity = entity
                  item = item }
        }
        |> function
            | Some result -> Ok result
            | None ->
                sprintf "failed to unwrap tile data at address %d" pointer
                |> Error

    let result =
        // start at 4MB offset because it's a Win32 application
        match seekMagicStart processHandle 4194304 with
        | Error message -> Error message
        | Ok magicOffset ->
            let luigiAi = openMagic magicOffset

            let openTilePointer (AddressCoordinate (x, y)) =
                let offset =
                    (x * luigiAi.mapHeight + y) * 24 // length of struct
                    + luigiAi.tilePointer

                tryUnwrapTile offset (x, y)

            let coordinates =
                List.allPairs [ 0 .. luigiAi.mapHeight - 1 ] [ 0 .. luigiAi.mapWidth - 1 ]

            let addressCoordinates: AddressCoordinate list =
                coordinates |> List.map AddressCoordinate

            let tileResults =
                List.map openTilePointer addressCoordinates
                |> List.sequenceResultM

            let playerEntity =
                tryUnwrapEntity luigiAi.playerEntityPointer

            match tileResults, playerEntity with
            | Ok results, Some player -> Ok(luigiAi, player, results)
            | _, None -> Error "entity data for player corrupt"
            | Error message, _ -> Error message

    CloseHandle(processHandle) |> ignore
    result
