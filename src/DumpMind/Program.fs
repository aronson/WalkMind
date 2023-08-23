open System
open System.IO
open System.Threading
open System.Threading.Tasks
open DiscordRPC
open DiscordRPC.Logging
open FSharp.Json
open NHotkey.WindowsForms
open System.Windows.Forms
open WalkMind.Memory
open DumpMind.Status


let executablePath = AppDomain.CurrentDomain.BaseDirectory
let discordControlFile = Path.Combine(executablePath, "nodiscord.txt")

let discord () =
    Task.Run(fun () ->
        use client = new DiscordRpcClient("914720093701832724")
        client.Logger <- ConsoleLogger(Level = LogLevel.Warning)
        client.OnReady.Add(fun message -> printfn "Received Ready from user %s" message.User.Username)
        client.OnPresenceUpdate.Add(fun message -> printfn "Received Update! %s" message.Presence.Details)
        client.Initialize() |> ignore

        let memory = Memory()

        let rec loop actionReady =
            Thread.Sleep(5000)

            if actionReady <> memory.actionReadyValue then
                client.SetPresence(getPresence ())
                loop memory.actionReadyValue
            else
                loop actionReady

        loop -1)

[<EntryPoint>]
[<STAThread>]
let main args =
    try
        let memory = Memory()

        // Discord integration can be disabled with any argument
        if not <| File.Exists(discordControlFile) && args.Length = 0 then
            discord () |> ignore
        else
            ()

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
