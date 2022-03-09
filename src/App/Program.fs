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

            let coordinateMap =
                let coords =
                    tiles |> List.map (fun x -> (x.row, x.col), x)

                Map.ofList coords

            let goal = Map.find (41, 58) coordinateMap

            printfn "Goal %A" goal

            let victories = aStar coordinateMap playerTile goal

            printfn "Victories: %A" victories

        printfn "I'm walking here"
        printfn "Press any key to exit..."
        System.Console.ReadKey() |> ignore
        0
    | Error message ->
        printfn "Process seek error: %s" message
        printfn "Press any key to exit..."
        System.Console.ReadKey() |> ignore
        1
