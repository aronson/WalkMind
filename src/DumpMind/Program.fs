open System
open FSharp.Json
open NHotkey.WindowsForms
open System.Windows.Forms
open WalkMind.Memory

[<EntryPoint>]
[<STAThread>]
let main _ =
    try
        let memory = Memory()

        let getPlayerString () =
            Option.get memory.player.entity |> Json.serialize

        let getEnemyString () =
            if memory.mapCursorIndex < 0 then
                None
            else
                match memory.tiles.[memory.mapCursorIndex].entity with
                | Some entity when entity <> Option.get memory.player.entity -> Some <| Json.serialize entity
                | _ -> None

        let getStrings () =
            let player = getPlayerString ()
            let enemy = getEnemyString ()

            match enemy with
            | None -> sprintf "[%s]" player
            | Some enemy -> sprintf "[\n%s,\n%s\n]" player enemy

        HotkeyManager.Current.AddOrReplace(
            "DumpGameData",
            Keys.F2 ||| Keys.Control,
            (fun _ _ ->
                try
                    Clipboard.SetText(getStrings ())
                    printfn "[%s] Dumped to clipboard..." (DateTime.Now.ToString("hh:mm:ss tt"))
                with e ->
                    printfn "%A" e)
        )

        printfn "Press Ctrl+F2 with an enemy highlighted to dump to clipboard...\n"

        // Enter message loop
        Application.Run()
    with e ->
        printfn "Exception encountered...\n%A" e
        printfn "Press any key to exit..."
        Console.ReadLine() |> ignore

    0 // return an integer exit code
