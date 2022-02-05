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
    let mutable lpNumberOfBytesRidden = 0

    ReadProcessMemory(hProcess, lpBaseAddress, buffer, dwSize, &lpNumberOfBytesRidden)
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

let seekMagic: Result<int * int, string> =
    match seekCogmindProcess with
    | Error message -> Error message
    | Ok cogmindProcess ->
        let processHandle = openProcess cogmindProcess
        let mutable PTR: Result<int * int, string> = Error "magic not found" // beginning of memory
        let primaryMagic = 1689123404
        let secondaryMagic = 2035498713

        // Search from 4 MB base offset to ~250 MB of process memory
        for offset in 4194304 .. 4 .. 2101346304 do
            match PTR with
            | Error _ ->
                let value = readInt offset processHandle

                if (value = (primaryMagic)) then
                    PTR <- Ok(offset, primaryMagic)
                    // Sometimes we find the code pointer instead, we need to learn about regions to fix that
                    printfn "Seek found first pointer at %d, searching for second" offset
                    let value2 = readInt (offset + 4) processHandle

                    if (value2 = secondaryMagic) then
                        printfn "Seek found second pointer at %d" (offset + 4)
                        // Can now infer movement value
                        let movementValue = readInt (offset + 8) processHandle
                        PTR <- Ok(offset + 8, movementValue)
                        ()
                    else
                        PTR <- Error "found only sparse result"
            | Ok _ -> ()

        CloseHandle(processHandle) |> ignore
        PTR
