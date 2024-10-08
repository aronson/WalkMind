/// Encapsulate all reads to foreign memory in Cogmind within this helper module
module WalkMind.Memory

open System.Diagnostics
open System.Runtime.InteropServices
open System
open Domain

/// Used to set focus to cogmind for input
[<DllImport("user32.dll")>]
extern int SetForegroundWindow(int hwnd)

/// Used to ensure we aren't sending inputs when Cogmind doesn't have focus
[<DllImport("user32")>]
extern int GetForegroundWindow()

module NativeMethods =
    [<DllImport("kernel32.dll")>]
    extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId)

    [<DllImport("kernel32.dll", SetLastError = true)>]
    extern bool ReadProcessMemory(
        IntPtr hProcess,
        IntPtr lpBaseAddress,
        IntPtr lpBuffer,
        UIntPtr nSize,
        int& lpNumberOfBytesRead
    )

    [<DllImport("kernel32.dll", SetLastError = true)>]
    extern bool CloseHandle(IntPtr hObject)

/// At runtime, we may encounter 0, 1, or more Cogmind processes. For now we only support one running at a time.
// TODO: Spawn Cogmind process ourselves?
let seekCogmindProcess: Result<Process, string> =
    // A simple search for the cogmind process based on its name
    let cogmindProcessCandidates = Process.GetProcessesByName("Cogmind")
    // Ensure there is only a single process to capture, and return it or die trying
    match cogmindProcessCandidates with
    | [||] -> Error "No process found for Cogmind"
    | [| cogmindProcess |] -> Ok cogmindProcess
    | _ -> Error "Multiple processes found for Cogmind"

[<StructLayout(LayoutKind.Sequential)>]
type LuigiAiData =
    struct
        [<field: MarshalAs(UnmanagedType.I4)>]
        val Magic1: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val Magic2: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val ActionReady: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val MapWidth: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val MapHeight: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val Depth: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val MapType: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val TilePointer: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val MapCursorIndex: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val PlayerEntityPointer: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val MachineHackingPointer: int
    end

[<Literal>]
let luigiAiByteLength = 44

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
[<Literal>]
let primaryMagic = 0x64ADFA4C

/// The second mutually-agreed upon magic number for the LuigiAi structure header
[<Literal>]
let secondaryMagic = 0x79533ED9

[<StructLayout(LayoutKind.Sequential)>]
type LuigiItemData =
    struct
        [<field: MarshalAs(UnmanagedType.I4)>]
        val Item: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val Integrity: int

        [<field: MarshalAs(UnmanagedType.U1)>]
        val Equipped: bool
    end

/// Very simple record type representing an item on the floor or equipped
type LuigiItem =
    { item: Item
      integrity: int
      equipped: bool }

[<Literal>]
let luigiItemByteLength = 12

[<StructLayout(LayoutKind.Sequential)>]
type LuigiEntityData =
    struct
        [<field: MarshalAs(UnmanagedType.I4)>]
        val Entity: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val Integrity: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val Faction: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val EntityActiveState: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val Exposure: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val Energy: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val Matter: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val Heat: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val Corruption: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val Speed: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val InventorySize: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val InventoryPointer: int
    end

[<Literal>]
let luigiEntityByteLength = 48

/// These records in tile data are player and non-player characters with a set of stats
type LuigiEntity =
    { entity: Entity
      integrity: int
      faction: int
      entityActiveState: int
      exposure: int
      energy: int
      matter: int
      heat: int
      corruption: int
      speed: int
      inventory: LuigiItem list }

[<StructLayout(LayoutKind.Sequential)>]
type LuigiPropData =
    struct
        [<field: MarshalAs(UnmanagedType.I4)>]
        val PropId: int

        [<field: MarshalAs(UnmanagedType.U1)>]
        val InteractivePiece: bool
    end

type LuigiProp = { prop: Prop; interactivePiece: bool }

[<StructLayout(LayoutKind.Sequential)>]
type LuigiTileData =
    struct
        [<field: MarshalAs(UnmanagedType.I4)>]
        val LastAction: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val LastFov: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val Cell: int

        [<field: MarshalAs(UnmanagedType.U1)>]
        val DoorOpen: bool

        [<field: MarshalAs(UnmanagedType.I4)>]
        val PropPointer: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val EntityPointer: int

        [<field: MarshalAs(UnmanagedType.I4)>]
        val ItemPointer: int
    end

[<Literal>]
let luigiTileByteLength = 28

/// These records are the core tile data for what is in Cogmind's current and past field of view
type LuigiTile =
    { col: int
      row: int
      lastAction: int
      cell: cell
      doorOpen: bool
      lastFov: int
      prop: LuigiProp option
      entity: LuigiEntity option
      item: LuigiItem option }


/// An abstraction to ensure that col and row are always passed in the same order when accessing tile data
type AddressCoordinate = AddressCoordinate of (int * int)

/// Encapsulates reads to the Cogmind process's memory as a proper F# OO type
type Memory() =
    /// The single, current running Cogmind process
    let cogmindProcess =
        match seekCogmindProcess with
        | Error message -> raise (Exception message)
        | Ok cogmindProcess -> cogmindProcess

    /// The handle Windows uses to read memory from the Cogmind process after it has been open
    let processHandle = cogmindProcess.Handle

    let chunkSize = uint32 4096
        
    let addPointers (p1: IntPtr) (p2: int) =
        IntPtr.op_Addition(p1, p2)

    let readInt32 (buffer: byte[]) (i: int) =
        BitConverter.ToInt32(buffer, i)

    let findMagicNumbers hProcess startAddress =
        let mutable buffer = Array.zeroCreate<byte> (int chunkSize)
        let bufferHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned)
        let pBuffer = bufferHandle.AddrOfPinnedObject()

        try
            let mutable bytesRead = 0

            let result =
                NativeMethods.ReadProcessMemory(hProcess, startAddress, pBuffer, (UIntPtr chunkSize), &bytesRead)

            if result then
                Seq.initInfinite id
                |> Seq.take (buffer.Length - 8)
                |> Seq.tryPick (fun i ->
                    let n1 = readInt32 buffer i
                    let n2 = readInt32 buffer (i + 4)

                    if n1 = primaryMagic && n2 = secondaryMagic then
                        Some (addPointers startAddress i)
                    else
                        None)
            else
                None
        finally
            bufferHandle.Free()

    let searchMemory (p: Process) baseAddress =
        let PROCESS_VM_READ = 0x0010
        let hProcess = NativeMethods.OpenProcess(PROCESS_VM_READ, false, p.Id)
        let chunkSizeInt = int chunkSize

        if hProcess = IntPtr.Zero then
            Error "Failed to open process."
        else
            let maxAttempts = (int p.VirtualMemorySize64) / chunkSizeInt

            let searchKnownAddresses =
                [0xC6465C; 0xC66724]
                |> List.map(IntPtr)
                |> List.tryFind (fun addr ->
                    match findMagicNumbers hProcess addr with
                    | Some _ -> true
                    | None -> false)

            let rec loop currentAddress attempts =
                if attempts > maxAttempts then
                    Error "Failed to find magic numbers after maximum attempts."
                else
                    match findMagicNumbers hProcess currentAddress with
                    | Some addr -> Ok addr
                    | None -> loop (addPointers currentAddress chunkSizeInt) (attempts + 1)

            try
                match searchKnownAddresses with
                | Some addr -> Ok addr
                | None -> loop baseAddress 0
            finally
                NativeMethods.CloseHandle(hProcess) |> ignore


    /// The location in memory in Cogmind's heap where the LuigiAi structure begins
    let magicPointer =
        match searchMemory cogmindProcess 4096000 with
        | Error message -> raise (Exception message)
        | Ok pointer -> pointer

    let liftLuigiItem =
        function
        | pointer when pointer = IntPtr.Zero -> None
        | pointer ->
            let bufferSize = uint32 luigiItemByteLength
            let buffer = Marshal.AllocHGlobal(int bufferSize)

            let mutable bytesRead = 0

            let result =
                NativeMethods.ReadProcessMemory(processHandle, pointer, buffer, (UIntPtr bufferSize), &bytesRead)

            if not result then
                failwith "Failed to read process memory."

            let itemData = Marshal.PtrToStructure<LuigiItemData>(buffer)
            Marshal.FreeHGlobal(buffer)

            { item = itemId itemData.Item
              integrity = itemData.Integrity
              equipped = itemData.Equipped }
            |> Some

    let liftLuigiItems startOffset length : LuigiItem array =
        Array.init length (fun i ->
            let elementPtr = IntPtr.op_Addition (startOffset, int (i * int luigiItemByteLength))
            liftLuigiItem elementPtr)
        |> Array.choose id

    let liftLuigiEntity =
        function
        | pointer when pointer = IntPtr.Zero -> None
        | pointer ->
            let bufferSize = uint32 (luigiEntityByteLength)
            let buffer = Marshal.AllocHGlobal(int bufferSize)
            let mutable bytesRead = 0

            let result =
                NativeMethods.ReadProcessMemory(processHandle, pointer, buffer, (UIntPtr bufferSize), &bytesRead)

            if not result then
                failwith "Failed to read process memory."

            let entityData = Marshal.PtrToStructure<LuigiEntityData>(buffer)
            Marshal.FreeHGlobal(buffer)

            { entity = enum<Entity> (entityData.Entity)
              integrity = entityData.Integrity
              faction = entityData.Faction
              entityActiveState = entityData.EntityActiveState
              exposure = entityData.Exposure
              energy = entityData.Energy
              matter = entityData.Matter
              heat = entityData.Heat
              corruption = entityData.Corruption
              speed = entityData.Speed
              inventory =
                liftLuigiItems entityData.InventoryPointer entityData.InventorySize
                |> List.ofArray }
            |> Some

    let liftLuigiProp =
        function
        | pointer when pointer = IntPtr.Zero -> None
        | pointer ->
            let bufferSize = uint32 (8)
            let buffer = Marshal.AllocHGlobal(int bufferSize)

            let mutable bytesRead = 0

            let result =
                NativeMethods.ReadProcessMemory(processHandle, pointer, buffer, (UIntPtr bufferSize), &bytesRead)

            if not result then
                failwith "Failed to read process memory."

            let propData = Marshal.PtrToStructure<LuigiPropData>(buffer)
            Marshal.FreeHGlobal(buffer)

            { prop = Domain.getProp propData.PropId
              interactivePiece = propData.InteractivePiece }
            |> Some


    let convertLuigiTileData (tileData: LuigiTileData) (AddressCoordinate(col, row)) : LuigiTile =
        { col = col
          row = row
          lastAction = tileData.LastAction
          cell = enum<cell> (tileData.Cell)
          doorOpen = tileData.DoorOpen
          lastFov = tileData.LastFov
          prop = liftLuigiProp (int tileData.PropPointer)
          entity = liftLuigiEntity (int tileData.EntityPointer)
          item = liftLuigiItem (int tileData.ItemPointer) }

    let liftLuigiTile pointer (AddressCoordinate(col, row)) =
        let bufferSize = uint32 (luigiTileByteLength)
        let buffer = Marshal.AllocHGlobal(int bufferSize)

        let mutable bytesRead = 0

        let result =
            NativeMethods.ReadProcessMemory(processHandle, pointer, buffer, (UIntPtr bufferSize), &bytesRead)

        if not result then
            failwith "Failed to read process memory."

        let tileData = Marshal.PtrToStructure<LuigiTileData>(buffer)
        Marshal.FreeHGlobal(buffer)
        convertLuigiTileData tileData (AddressCoordinate(col, row))

    let liftLuigiTiles pointer mapWidth mapHeight =
        let elementSize = uint32 (luigiTileByteLength)
        let length = mapWidth * mapHeight
        let bufferSize = uint32 (length * int elementSize)
        let buffer = Marshal.AllocHGlobal(int bufferSize)

        let mutable bytesRead = 0

        let result =
            NativeMethods.ReadProcessMemory(processHandle, pointer, buffer, (UIntPtr bufferSize), &bytesRead)

        if not result then
            failwith "Failed to read process memory."

        let innerStructArray =
            Array.init length (fun i ->
                let elementPtr = IntPtr.op_Addition (buffer, int (i * int elementSize))
                Marshal.PtrToStructure<LuigiTileData>(elementPtr))

        Marshal.FreeHGlobal(buffer)

        List.allPairs [ 0 .. mapWidth - 1 ] [ 0 .. mapHeight - 1 ]
        |> List.map (fun (row, col) -> AddressCoordinate(col, row), (row * mapHeight) + col)
        |> List.map (fun (coord, offset) -> innerStructArray.[offset], coord)
        |> List.map (fun (data, offset) -> convertLuigiTileData data offset)

    let liftLuigiAi () : LuigiAi =
        let bufferSize = uint32 (luigiAiByteLength)
        let buffer = Marshal.AllocHGlobal(int bufferSize)

        let mutable bytesRead = 0

        let result =
            NativeMethods.ReadProcessMemory(processHandle, magicPointer, buffer, (UIntPtr bufferSize), &bytesRead)

        if not result then
            failwith "Failed to read process memory."

        let luigiAiData = Marshal.PtrToStructure<LuigiAiData>(buffer)
        Marshal.FreeHGlobal(buffer)

        let result =
            { magic1 = luigiAiData.Magic1
              magic2 = luigiAiData.Magic2
              actionReady = luigiAiData.ActionReady
              depth = luigiAiData.Depth
              mapHeight = luigiAiData.MapHeight
              mapWidth = luigiAiData.MapWidth
              mapType = enum<MapType> (luigiAiData.MapType)
              tilePointer = int luigiAiData.TilePointer
              mapCursorIndex = luigiAiData.MapCursorIndex
              playerEntityPointer = int luigiAiData.PlayerEntityPointer
              machineHackingPointer = int luigiAiData.MachineHackingPointer }

        result


    member _.actionReadyValue = liftLuigiAi().actionReady

    member _.mapType = liftLuigiAi().mapType

    member _.mapWidth = liftLuigiAi().mapWidth

    member _.mapHeight = liftLuigiAi().mapHeight

    member _.startTilePointer = liftLuigiAi().tilePointer

    member this.tiles = liftLuigiTiles this.startTilePointer this.mapWidth this.mapHeight

    member this.tile
        with get (col, row) =

            let offset =
                (row * this.mapHeight + col) * luigiTileByteLength + this.startTilePointer

            liftLuigiTile offset (AddressCoordinate(col, row))


    member _.depth = liftLuigiAi().depth

    member _.mapCursorIndex = liftLuigiAi().mapCursorIndex

    member this.player =
        let filterCogmindTile tile =
            match tile.entity with
            | Some entity when entity.entity = Entity.Cogmind -> true
            | _ -> false

        this.tiles |> List.find filterCogmindTile

    member _.activateCogmindWindow() =
        SetForegroundWindow(cogmindProcess.MainWindowHandle |> int) |> ignore

    member _.isCogmindForegroundWindow() =
        cogmindProcess.MainWindowHandle |> int = GetForegroundWindow()
