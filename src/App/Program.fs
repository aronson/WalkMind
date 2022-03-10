open Magic
open System.Runtime.InteropServices
open AStar

[<DllImport("user32.dll")>]
extern int SetForegroundWindow(int hwnd)


[<EntryPoint>]
let main args =
    match seekCogmindProcess with
    | Ok cogmindProcess ->
        let activateCogmindWindow () =
            SetForegroundWindow(cogmindProcess.MainWindowHandle |> int)
            |> ignore

        match openMagicResult cogmindProcess None with
        | Error message -> printfn "Seek failed... '%s'" message
        | Ok (luigiAi, _, _, magicOffset) ->

            let printPath path goal (tiles: LuigiTile list) =
                for col in 0 .. luigiAi.mapWidth - 1 do
                    for row in 0 .. luigiAi.mapHeight - 1 do
                        let tile = tiles.[row * luigiAi.mapHeight + col]

                        if List.contains tile path then
                            match tile.entity with
                            | Some entity when entity.entity = Domain.entity.Cogmind -> printf "@"
                            | _ when tile = goal -> printf "@"
                            | _ -> printf "+"
                        else
                            printf "%s" (Model.cellToChar tile)

                    printfn ""

            let playerTile tiles =
                tiles
                |> List.find (fun tile ->
                    match tile.entity with
                    | Some entity when entity.entity = Domain.entity.Cogmind -> true
                    | _ -> false)

            let mobs tiles =
                tiles
                |> List.find (fun tile ->
                    match tile.entity with
                    | Some entity when entity.entity <> Domain.entity.Cogmind -> true
                    | _ -> false)

            printfn "Player tile:\n%A" playerTile
            printfn "Mob tile(s):\n%A" mobs

            let coordinateMap tiles =
                let coords =
                    tiles |> List.map (fun x -> (x.col, x.row), x)

                Map.ofList coords

            let exits (tiles: LuigiTile list) =
                tiles
                |> List.filter (function
                    | exit when Model.cellToChar exit = ">" -> true
                    | _ -> false)

            let goal tiles =
                let playerTile = playerTile tiles
                let coordinateMap = coordinateMap tiles

                match exits tiles with
                | [ exit ] -> exit
                | exit :: _ -> exit
                | [] ->
                    Goalfinding.seekEdge coordinateMap playerTile
                    |> Option.get

            printfn "Goal :\n%A" goal

            let path tiles =
                let goal = goal tiles
                let playerTile = playerTile tiles
                let coordinateMap = coordinateMap tiles

                match aStar coordinateMap playerTile goal with
                | None -> Error "no path found to goal"
                | Some path -> List.choose id path |> Ok


            printfn "Path:\n%A" path

            printfn "Beginning walk process... Press any key to step"

            let rec waitActionReady lastAction nextDirection =
                nextDirection ()

                match openMagicResult cogmindProcess (Some magicOffset) with
                | Error message -> raise (System.Exception(message))
                | Ok (luigiAi, _, _, _) when luigiAi.actionReady > lastAction ->
                    // we moved!
                    luigiAi.actionReady
                | _ ->
                    System.Threading.Thread.Sleep(17) // 16.66666... ms is one frame at 60 FPS
                    waitActionReady lastAction nextDirection

            let doWalkLoop lastAction (step, next) =
                let nextDirection () =
                    Movement.getDirection step next
                    |> Movement.walkDirection
                    |> ignore
                // check if we actually moved
                waitActionReady lastAction nextDirection

            activateCogmindWindow ()

            let moveToNewGoal lastAction =
                match openMagicResult cogmindProcess (Some magicOffset) with
                | Error message -> raise (System.Exception(message))
                | Ok (luigiAi, _, tiles, _) ->
                    match path tiles with
                    | Error message -> Error message
                    | Ok path ->
                        let pathForward = List.rev path

                        List.pairwise pathForward
                        |> List.fold doWalkLoop luigiAi.actionReady
                        |> Ok

            let mutable lastAction = luigiAi.actionReady

            while (true) do
                match moveToNewGoal lastAction with
                | Error _ -> ()
                | Ok actionReady -> lastAction <- actionReady

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
