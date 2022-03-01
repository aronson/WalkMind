open System
open System.IO
open Magic
open Model

[<EntryPoint>]
let main args =
    match Magic.seekMagic with
    | Error message -> printfn "Seek failed... '%s'" message
    | Ok (luigiAi, tiles) ->
        printfn "LuigiAi: %A" luigiAi

        for x in 0 .. luigiAi.mapHeight - 1 do
            for y in 0 .. luigiAi.mapWidth - 1 do
                printf "%s" (cellToChar tiles.[y * luigiAi.mapHeight + x])

            printfn ""

    printfn "I'm walking here"
    0
