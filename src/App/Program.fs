open System
open System.IO
open Magic

[<EntryPoint>]
let main args =
    match Magic.seekMagic with
    | Error message -> printfn "Seek failed... '%s'" message
    | Ok data -> printfn "Seek succeeded! Inferring movement value is %A" data

    printfn "I'm walking here"
    0
