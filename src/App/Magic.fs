open System.Process
module Magic =
  [<DllImport("kernel32.dll", SetLastError = true)>]
  extern bool ReadProcessMemory(
        IntPtr hProcess,
        IntPtr lpBaseAddress,
        out byte[] lpBuffer,
        int dwSize,
        out int lpNumberOfBytesRead
      );

  [<DllImport("kernel32.dll")>]
  extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

  [<DllImport("kernel32.dll", SetLastError = true)>]
  [<return: MarshalAs(UnmanagedType.Bool)>]
  extern bool CloseHandle(IntPtr hObject);

  let seekCogmindProcess: Result<Process> =
    let cogmindProcessCandidates = Process.GetProcessesByName("Cogmind")
    match cogmindProcessCandidates with
    | [] -> Error "Cogmind not launched"
    | [cogmindProcess] -> Ok cogmindProcess
    | _ -> Error "Multiple processes found for Cogmind"
  
  let seekMagic : IntPtr =
    Result.map(seekCogmindProcess) 
    <| function
    | Error message -> Error message
    | Ok cogmindProcess -> 
    let pointer = OpenProcess(0x10 | 0x20, true, cogmindProcess.Id);
    let mut PTR : IntPtr = 0x0; // beginning of memory
    let magicTarget : byte array = [|1689123404; 2035498713|]
