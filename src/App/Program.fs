open System
open System.IO
open Magic
open Model

[<EntryPoint>]
let main args =
    match seekCogmindProcess with
    | Ok cogmindProcess ->
        match openMagicResult cogmindProcess with
        | Error message -> printfn "Seek failed... '%s'" message
        | Ok (luigiAi, player, tiles) ->

            for x in 0 .. luigiAi.mapHeight - 1 do
                for y in 0 .. luigiAi.mapWidth - 1 do
                    printf "%s" (cellToChar tiles.[y * luigiAi.mapHeight + x])

                printfn ""

            printfn "LuigiAi:\n%A" luigiAi
            printfn "Player state:\n%A" player

        printfn "I'm walking here"
        0
    | Error message ->
        printfn "Process seek error: %s" message
        1
