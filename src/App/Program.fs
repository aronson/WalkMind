open System
open System.IO
open Magic

[<EntryPoint>]
let main args =
    match Magic.seekMagic with
    | Error message -> printfn "Seek failed..."
    | Ok pointer -> printfn "Seek succeeded! Pointer was: %s" (pointer.ToString())

    printfn "I'm walking here"
    0
