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
        | Ok (luigiAi, player, tiles, magicOffset) ->

            let printPath path goal =
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

            let printState luigiAi player =
                printfn "LuigiAi:\n%A" luigiAi
                printfn "Player state:\n%A" player

            let playerTile =
                tiles
                |> List.find (fun tile ->
                    match tile.entity with
                    | Some entity when entity.entity = Domain.entity.Cogmind -> true
                    | _ -> false)

            let mobs =
                tiles
                |> List.find (fun tile ->
                    match tile.entity with
                    | Some entity when entity.entity <> Domain.entity.Cogmind -> true
                    | _ -> false)

            printfn "Player tile:\n%A" playerTile
            printfn "Mob tile(s):\n%A" mobs

            let coordinateMap =
                let coords =
                    tiles |> List.map (fun x -> (x.col, x.row), x)

                Map.ofList coords

            let goal =
                Goalfinding.seekEdge coordinateMap playerTile
                |> Option.get

            printfn "Goal :\n%A" goal

            let path = aStar coordinateMap playerTile goal

            printfn "Path:\n%A" path

            let victoryLap = Option.get path |> List.choose id

            printfn "Beginning walk process... Press any key to step"

            let pathForward = List.rev victoryLap

            let rec waitActionReady lastAction =
                match openMagicResult cogmindProcess (Some magicOffset) with
                | Error message -> raise (System.Exception(message))
                | Ok (luigiAi, _, _, _) when luigiAi.actionReady > lastAction -> luigiAi.actionReady
                | _ ->
                    System.Threading.Thread.Sleep(17) // 16.66666... ms is one frame at 60 FPS
                    waitActionReady lastAction

            let doWalkLoop lastAction (step, next) =
                let nextDirection = Movement.getDirection step next
                Movement.walkDirection nextDirection |> ignore
                waitActionReady lastAction

            activateCogmindWindow ()

            List.pairwise pathForward
            |> List.fold doWalkLoop luigiAi.actionReady
            |> ignore


        printfn "I'm walking here"
        printfn "Press any key to exit..."
        System.Console.ReadKey() |> ignore
        0
    | Error message ->
        printfn "Process seek error: %s" message
        printfn "Press any key to exit..."
        System.Console.ReadKey() |> ignore
        1
