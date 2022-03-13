open Magic
open System.Runtime.InteropServices
open AStar
open Goalfinding
open FSharpx.State
open FSharpx.Collections
open Model

[<DllImport("user32.dll")>]
extern int SetForegroundWindow(int hwnd)

type PathEnd =
    | Unexplored of LuigiTile
    | Stairs of LuigiTile

type WaitLoopState =
    { loopBuster: int
      magicOffset: int
      thisStep: LuigiTile
      nextStep: LuigiTile }

let getNextMagicOrThrow cogmindProcess =
    match openMagicResult cogmindProcess None with
    | Error message -> raise (System.InvalidOperationException(sprintf "Failed to unpack Cogmind data:\n%A" message))
    | Ok (luigiAi, playerEntity, tiles, magicOffset) -> (luigiAi, playerEntity, tiles, magicOffset)

let getNextMagic cogmindProcess offset =
    match openMagicResult cogmindProcess (Some offset) with
    | Error message -> raise (System.InvalidOperationException(sprintf "Failed to unpack Cogmind data:\n%A" message))
    | Ok (luigiAi, playerEntity, tiles, magicOffset) -> (luigiAi, playerEntity, tiles, magicOffset)

type WalkResult =
    | Moved
    | Blocked

[<EntryPoint>]
let main args =
    match seekCogmindProcess with
    | Ok cogmindProcess ->
        match seekMagicStart cogmindProcess.Handle 4194304 with
        | Error message -> 1
        | Ok initialOffset ->
            let mutable magicOffset = initialOffset
            let getMagicState () = MagicState(magicOffset, cogmindProcess)

            let activateCogmindWindow () =
                SetForegroundWindow(cogmindProcess.MainWindowHandle |> int)
                |> ignore

            let coordinateMap tiles =
                let coords =
                    tiles |> List.map (fun x -> (x.col, x.row), x)

                Map.ofList coords

            let exits (tiles: LuigiTile list) =
                tiles
                |> List.filter (function
                    | exit when cellToChar exit = ">" -> true
                    | _ -> false)

            let goal tiles : PathEnd =
                let playerTile = Model.playerTile tiles
                let coordinateMap = coordinateMap tiles

                match exits tiles with
                | [ exit ] -> Stairs exit
                | exit :: _ -> Stairs exit
                | [] ->
                    // No exits, seek nearest Unexplored tile
                    let x =
                        seekEdge coordinateMap playerTile |> Option.get

                    match neighborNodes coordinateMap Set.empty x with
                    | Goal goal -> Unexplored goal
                    | Neighbors neighbors ->
                        List.find
                            (fun x ->
                                match mapTileOccupancy x with
                                | Occupied _ -> true
                                | Vacant -> true
                                | Obstructed -> false)
                            neighbors
                        |> Unexplored

            let path tiles =
                let result = goal tiles

                match result with
                | Unexplored goal
                | Stairs goal ->
                    let playerTile = Model.playerTile tiles
                    let coordinateMap = coordinateMap tiles

                    match aStar coordinateMap playerTile goal with
                    | None -> Error "no path found to goal"
                    | Some path -> (List.choose id path, result) |> Ok

            /// Put steps in a queue, peek the queue, try to step, pop the queue, that sort of thing
            /// Model steps as their own type with an executor I think
            let getNewStepQueueToGoal tiles =
                match path tiles with
                | Error message -> Error message
                | Ok (path, goal) ->
                    let queue =
                        List.rev path |> List.pairwise |> Queue.ofList

                    Ok(queue, goal)

            let isStairs tile =
                match tile.cell with
                | Domain.cell.STAIRS_SCR
                | Domain.cell.STAIRS_MAT
                | Domain.cell.STAIRS_MIN
                | Domain.cell.STAIRS_STO -> true
                | _ -> false

            let walkOneStepTestBlocked (step: LuigiTile) (next: LuigiTile) =
                let luigiAi =
                    openMagic cogmindProcess.Handle magicOffset

                let lastActionReady = luigiAi.actionReady
                // Try to walk with input simulator
                Movement.takeStep step next |> ignore
                System.Threading.Thread.Sleep(17) // 16.66666... ms is one frame at 60 FPS

                // Don't check yet, it might throw
                let compareActionReady () =
                    let ((nextLuigiAi, _, tiles, _), (nextOffset, _)) =
                        readMagic (MagicState(magicOffset, cogmindProcess))

                    magicOffset <- nextOffset

                    let updatedNextTile =
                        coordinateMap tiles
                        |> Map.find (next.row, next.col)

                    match mapTileOccupancy updatedNextTile with
                    | Obstructed -> Blocked
                    | _ ->
                        match lastActionReady = nextLuigiAi.actionReady with
                        | true ->
                            System.Threading.Thread.Sleep(17) // 16.66666... ms is one frame at 60 FPS
                            Blocked
                        | false -> Moved


                match isStairs next with
                | true ->
                    // Dangerous to check magic now
                    try
                        compareActionReady ()
                    with
                    // if we threw, we're on a transition or evolve screen
                    | _ -> Moved
                // if we throw here we should probably stop sending inputs
                | false -> compareActionReady ()

            let rec tryStepTwice state : WalkResult =
                match walkOneStepTestBlocked state.thisStep state.nextStep with
                | Moved -> Moved
                | Blocked when state.loopBuster > 1 -> Blocked
                | _ ->
                    System.Threading.Thread.Sleep(17)
                    tryStepTwice { state with loopBuster = state.loopBuster + 1 }

            let stepTwice (stepQueue: Queue<LuigiTile * LuigiTile>) =
                if Queue.length stepQueue = 0 then
                    Ok()
                else
                    let (step, next) = stepQueue.Head
                    // check if we actually moved
                    match
                        tryStepTwice
                            { loopBuster = 0
                              magicOffset = magicOffset
                              thisStep = step
                              nextStep = next }
                        with
                    | Blocked -> Error(step, next)
                    | Moved -> Ok()


            let rec goalStep stepQueue =
                match stepTwice stepQueue with
                | Ok () ->
                    if Queue.length stepQueue = 0 then
                        Ok()
                    else
                        let newQueue = Queue.tail stepQueue
                        goalStep newQueue
                | Error pair -> Error pair

            let pathMapStep tiles =
                let queue = getNewStepQueueToGoal tiles

                match queue with
                | Error message -> raise (System.InvalidOperationException(message))
                | Ok (queue, goal) ->
                    match goalStep queue with
                    | Error pair -> Error pair
                    | Ok () -> Ok goal


            activateCogmindWindow ()

            while (true) do
                let (luigiAi, _, tiles, _), (nextOffset, _) = getMagicState () |> readMagic

                magicOffset <- nextOffset

                match path tiles with
                | Error message -> printfn "Error:%A" message
                | Ok (path, goal) ->
                    match goal with
                    | Unexplored goal
                    | Stairs goal ->
                        printPath path goal (luigiAi.mapWidth, luigiAi.mapHeight) tiles

                        match (getNewStepQueueToGoal tiles) with
                        | Error message -> printfn "Error:%A" message
                        | Ok (stepQueue, pathEnd) ->
                            printfn "Step Queue:\n%A" stepQueue
                            let (step, next) = Queue.head stepQueue
                            printfn "Walk step:\n%A" (goalStep stepQueue)

            ()

            printfn "I'm walking here"
            printfn "Press any key to exit..."
            System.Console.ReadKey() |> ignore
            0
    | Error message ->
        printfn "Process seek error: %s" message
        printfn "Press any key to exit..."
        System.Console.ReadKey() |> ignore
        1
