open Magic
open Movement
open AStar

[<EntryPoint>]
let main args =
    match seekCogmindProcess with
    | Ok cogmindProcess ->
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

            let victories = aStar coordinateMap playerTile goal

            printfn "Victory:\n%A" victories

            let victory = Option.get victories |> List.choose id

            for col in 0 .. luigiAi.mapWidth - 1 do
                for row in 0 .. luigiAi.mapHeight - 1 do
                    let tile = tiles.[row * luigiAi.mapHeight + col]

                    if List.contains tile victory then
                        match tile.entity with
                        | Some entity when entity.entity = Domain.entity.Cogmind -> printf "@"
                        | _ when tile = goal -> printf "@"
                        | _ -> printf "+"
                    else
                        printf "%s" (Model.cellToChar tile)

                printfn ""

        printfn "I'm walking here"
        printfn "Press any key to exit..."
        System.Console.ReadKey() |> ignore
        0
    | Error message ->
        printfn "Process seek error: %s" message
        printfn "Press any key to exit..."
        System.Console.ReadKey() |> ignore
        1
