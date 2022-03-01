module Magic

open System.Diagnostics
open System.Runtime.InteropServices
open System

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
      tilePointer: IntPtr }

type MagicResult = Result<LuigiAi, string>

let seekMagic: MagicResult =
    match seekCogmindProcess with
    | Error message -> Error message
    | Ok cogmindProcess ->
        let processHandle = openProcess cogmindProcess
        let primaryMagic = 1689123404
        let secondaryMagic = 2035498713
        // four byte-aligned struct
        let (secondaryMagicOffset, actionReadyOffset, mapWidthOffset, mapHeightOffset, mapDataOffset) =
            (4, 8, 12, 16, 20)

        let rec seekNext offset : MagicResult =
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
                              tilePointer = new IntPtr(readInt (offset + mapDataOffset) processHandle) }
                    else
                        seekNext (offset + 4)
                else
                    seekNext (offset + 4)

        let result = seekNext 4194304

        CloseHandle(processHandle) |> ignore
        result
