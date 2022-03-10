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

        match openMagicResult cogmindProcess with
        | Error message -> printfn "Seek failed... '%s'" message
        | Ok (luigiAi, player, tiles) ->
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

            let goal = Map.find (53, 50) coordinateMap

            printfn "Goal :\n%A" goal

            let path = aStar coordinateMap playerTile goal

            printfn "Path:\n%A" path

            let victoryLap = Option.get path |> List.choose id

            for col in 0 .. luigiAi.mapWidth - 1 do
                for row in 0 .. luigiAi.mapHeight - 1 do
                    let tile = tiles.[row * luigiAi.mapHeight + col]

                    if List.contains tile victoryLap then
                        match tile.entity with
                        | Some entity when entity.entity = Domain.entity.Cogmind -> printf "@"
                        | _ when tile = goal -> printf "@"
                        | _ -> printf "+"
                    else
                        printf "%s" (Model.cellToChar tile)

                printfn ""

            printfn "Beginning walk process... Press any key to step"

            let pathForward = List.rev victoryLap

            List.pairwise pathForward
            |> List.map (fun (step, next) ->
                System.Console.ReadKey() |> ignore
                activateCogmindWindow ()
                let nextDirection = Movement.getDirection step next
                Movement.walkDirection nextDirection |> ignore
                printfn "Press any key to step...")
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
