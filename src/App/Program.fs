open System
open System.IO
open Magic
open Domain
open Movement

[<EntryPoint>]
let main args =
    match seekCogmindProcess with
    | Ok cogmindProcess ->
        match openMagicResult cogmindProcess with
        | Error message -> printfn "Seek failed... '%s'" message
        | Ok (luigiAi, player, tiles) ->
            printfn "LuigiAi:\n%A" luigiAi
            printfn "Player state:\n%A" player

            let magic =
                { ai = luigiAi
                  player = player
                  tiles = List.toArray tiles }

            let playerTile =
                tiles
                |> List.find (fun tile ->
                    match tile.entity with
                    | Some entity when entity.entity = Domain.entity.Cogmind -> true
                    | _ -> false)

            let coordinateMap =
                let coords =
                    Array.toList magic.tiles
                    |> List.map (fun x -> (x.row, x.col), x)

                Map.ofList coords

            let goals = neighborNodes coordinateMap playerTile

            let victories =
                (List.map (fun x -> aStar coordinateMap playerTile x) goals)
                |> List.find (Option.isSome)

            printfn "Victories: %A" victories

        printfn "I'm walking here"
        0
    | Error message ->
        printfn "Process seek error: %s" message
        1
