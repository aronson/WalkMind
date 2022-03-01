open System
open System.IO
open Magic

[<EntryPoint>]
let main args =
    match Magic.seekMagic with
    | Error message -> printfn "Seek failed... '%s'" message
    | Ok (luigiAi, tiles) ->
        printfn "LuigiAi: %A" luigiAi
        printfn "Tiles: %A" (List.filter (fun x -> Option.isSome x.entity) tiles)

    printfn "I'm walking here"
    0
