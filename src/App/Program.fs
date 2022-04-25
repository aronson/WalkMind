open Magic
open AStar
open Goalfinding
open FSharpx.Collections
open Model

/// We need to wait a little bit before checking magic data if we exited
type PathEnd =
    | Unexplored of LuigiTile
    | Stairs of LuigiTile

/// A state representing our attempt to walk forward in a given step
type WaitLoopState =
    { loopBuster: int
      thisStep: LuigiTile
      nextStep: LuigiTile }

/// A type modeling the result of using input simulator to try to move forward along a path
type WalkResult =
    | Moved
    | Blocked

[<EntryPoint>]
let main args =
    let magic = Magic()

    /// It's easier to pull coordinates out in a functional way with a map of (col, row)
    let coordinateMap tiles =
        let coords =
            tiles |> List.map (fun x -> (x.col, x.row), x)

        Map.ofList coords

    /// This function filters all tiles once in or in FOV to find those with exits using a bad hack
    let exits (tiles: LuigiTile list) =
        tiles
        |> List.filter (function
            | exit when cellToChar exit = ">" -> true
            | _ -> false)

    /// Returns either an Unexplored tile or some Stairs tile
    let goal tiles : PathEnd =
        let playerTile = Model.playerTile tiles
        let coordinateMap = coordinateMap tiles

        match exits tiles with
        | [ exit ] -> Stairs exit
        | exit :: _ -> Stairs exit
        | [] ->
            // No exits, seek nearest Unexplored tile
            seekEdge coordinateMap playerTile
            |> Option.get
            |> Unexplored

    /// This function seeks a goal and returns a path from Cogmind to it, or it fails to find a path
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

    /// Similar to the path function, but returns a Queue
    let getNewStepQueueToGoal tiles =
        match path tiles with
        | Error message -> Error message
        | Ok (path, goal) ->
            let queue =
                List.rev path |> List.pairwise |> Queue.ofList

            Ok(queue, goal)

    /// Filters a tile for if it it's stairs interesting in Materials
    let isStairs tile =
        match tile.cell with
        | Domain.cell.STAIRS_SCR
        | Domain.cell.STAIRS_MAT
        | Domain.cell.STAIRS_MIN
        | Domain.cell.STAIRS_STO -> true
        | _ -> false

    /// A complicated function with side effects, it tries to press a button and tests if it that did anything in-game.
    /// If it didn't, it will try to move once more, then return that it's Blocked.
    /// If it did move, it happy returns that it Moved.
    let walkOneStepTestBlocked (step: LuigiTile) (next: LuigiTile) =
        // Try to walk with input simulator
        Movement.takeStep step next |> ignore
        System.Threading.Thread.Sleep(17) // 16.66666... ms is one frame at 60 FPS

        let lastActionReady = magic.actionReadyValue
        // Don't check yet, it might throw
        let compareActionReady () =
            let updatedNextTile =
                coordinateMap magic.tiles
                |> Map.find (next.row, next.col)

            match mapTileOccupancy updatedNextTile with
            | Obstructed -> Blocked
            | _ ->
                match lastActionReady = magic.actionReadyValue with
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

    /// This walks through a step queue with walkOneStepTestBlocked
    let rec tryStepTwice state : WalkResult =
        match walkOneStepTestBlocked state.thisStep state.nextStep with
        | Moved -> Moved
        | Blocked when state.loopBuster > 1 -> Blocked
        | _ ->
            System.Threading.Thread.Sleep(17)
            tryStepTwice { state with loopBuster = state.loopBuster + 1 }

    /// This function steps through one queue member (start and destination tile for one step)
    let stepTwice (stepQueue: Queue<LuigiTile * LuigiTile>) =
        if Queue.length stepQueue = 0 then
            Ok()
        else
            let (step, next) = stepQueue.Head
            // check if we actually moved
            match
                tryStepTwice
                    { loopBuster = 0
                      thisStep = step
                      nextStep = next }
                with
            | Blocked -> Error(step, next)
            | Moved -> Ok()

    /// Steps through a queue of step pairs until there are none left
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


    magic.activateCogmindWindow ()
    System.Threading.Thread.Sleep(150)

    while (true) do
        // Before walking, make sure we have focus
        if not (magic.isCogmindForegroundWindow ()) then
            printfn "Lost focus to window, waiting for user input..."
            System.Console.ReadKey() |> ignore
            magic.activateCogmindWindow ()
            System.Threading.Thread.Sleep(500)

        match path magic.tiles with
        | Error message -> printfn "Error:%A" message
        | Ok (path, goal) ->
            match goal with
            | Unexplored goal
            | Stairs goal ->
                printPath path goal (magic.mapWidth, magic.mapHeight) magic.tiles

                match (getNewStepQueueToGoal magic.tiles) with
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
