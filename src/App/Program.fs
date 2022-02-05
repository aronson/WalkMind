open System
open System.IO
open Magic

[<EntryPoint>]
let main args =
    match Magic.seekMagic with
    | Error message -> printfn "Seek failed... '%s'" message
    | Ok pointer -> printfn "Seek succeeded! Inferring movement value is %d" (snd pointer)

    printfn "I'm walking here"
    0
