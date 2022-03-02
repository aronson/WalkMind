module Magic

open System.Diagnostics
open System.Runtime.InteropServices
open System
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
      tilePointer: int }

let primaryMagic = 1689123404
let secondaryMagic = 2035498713
// four byte-aligned struct
let (secondaryMagicOffset, actionReadyOffset, mapWidthOffset, mapHeightOffset, mapDataOffset) = (4, 8, 12, 16, 20)

type LuigiItem = { item: item; integrity: int }
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
    { x: int
      y: int
      lastAction: int
      cell: cell
      lastFov: int
      propPointer: int option
      entity: LuigiEntity option
      item: item option }

let (lastActionOffset, cellOffset, lastFovOffset, propPointerOffset, entityPointerOffset, itemPointerOffset) =
    (0, 4, 8, 12, 16, 20)

type AddressCoordinate = AddressCoordinate of (int * int)

type MagicResult = Result<LuigiAi * LuigiTile list, string>

let seekMagic: MagicResult =
    match seekCogmindProcess with
    | Error message -> Error message
    | Ok cogmindProcess ->
        let processHandle = openProcess cogmindProcess

        let rec seekNext offset : Result<LuigiAi, string> =
            if (offset >= 210346304) then
                Error "magic not found before 250 MiB"
            else
                let value = readInt offset processHandle

                if (value = (primaryMagic)) then
                    // Sometimes we find the code pointer instead, we need to learn about regions to fix that
                    printfn "Seek found first pointer at %d" offset

                    let value2 =
                        readInt (offset + secondaryMagicOffset) processHandle

                    if (value2 = secondaryMagic) then
                        printfn "Seek found second pointer at %d" (offset + secondaryMagicOffset)
                        // Can now infer movement value
                        Ok
                            { magic1 = primaryMagic
                              magic2 = secondaryMagic
                              actionReady = readInt (offset + actionReadyOffset) processHandle
                              mapWidth = readInt (offset + mapWidthOffset) processHandle
                              mapHeight = readInt (offset + mapHeightOffset) processHandle
                              tilePointer = readInt (offset + mapDataOffset) processHandle }
                    else
                        seekNext (offset + 4)
                else
                    seekNext (offset + 4)

        let unwrapPointer =
            function
            | value when value > 0 -> readInt value processHandle |> Some
            | _ -> None

        let unwrapItem pointer : item =
            readInt pointer processHandle |> enum<item>

        let unwrapEntityId pointer : entity =
            readInt pointer processHandle |> enum<entity>

        let unwrapEntity pointer : LuigiEntity option =
            opt {
                let entity = pointer |> unwrapEntityId
                let! integrity = pointer + entityIntegrityOffset |> unwrapPointer
                let! faction = pointer + entityFactionOffset |> unwrapPointer
                let! entityActiveState = pointer + entityActiveStateOffset |> unwrapPointer
                let! exposure = pointer + entityExposureOffset |> unwrapPointer
                let! energy = pointer + entityEnergyOffset |> unwrapPointer
                let! matter = pointer + entityMatterOffset |> unwrapPointer
                let! heat = pointer + entityHeatOffset |> unwrapPointer
                let! corruption = pointer + entityCorruptionOffset |> unwrapPointer
                let! speed = pointer + entitySpeedOffset |> unwrapPointer

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

        let result =
            // start at 4MB offset because it's a Win32 application
            match seekNext 4194304 with
            | Error message -> Error message
            | Ok luigiAi ->
                let openTilePointer (AddressCoordinate (x, y)) =
                    let offset =
                        (x * luigiAi.mapHeight + y) * 24 // length of struct
                        + luigiAi.tilePointer


                    let prop =
                        readInt (offset + propPointerOffset) processHandle
                        |> unwrapPointer

                    let entity =
                        readInt (offset + entityPointerOffset) processHandle
                        |> unwrapEntity

                    let item =
                        readInt (offset + itemPointerOffset) processHandle
                        |> function
                            | value when value > 0 -> unwrapItem value |> Some
                            | _ -> None

                    { x = x
                      y = y
                      lastAction = readInt offset processHandle
                      cell =
                        readInt (offset + cellOffset) processHandle
                        |> enum<cell>
                      lastFov = readInt (offset + lastFovOffset) processHandle
                      propPointer = prop
                      entity = entity
                      item = item }

                let coordinates =
                    List.allPairs [ 0 .. luigiAi.mapHeight - 1 ] [ 0 .. luigiAi.mapWidth - 1 ]

                let addressCoordinates: AddressCoordinate list =
                    coordinates |> List.map AddressCoordinate

                Ok(luigiAi, List.map openTilePointer addressCoordinates)

        CloseHandle(processHandle) |> ignore
        result
