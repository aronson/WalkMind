open System
open FSharp.Json
open NHotkey
open NHotkey.WindowsForms
open System.Windows.Forms
open System.Windows.Input
open WalkMind.Memory

[<EntryPoint>]
[<STAThread>]
let main argv =
    let memory = Memory()
    let getPlayerString() = Option.get memory.player.entity |> Json.serialize
    let getEnemyString() =
        match memory.tiles.[memory.mapCursorIndex].entity with
        | None -> None
        | Some entity ->
            Some <| Json.serialize entity
            
    let getStrings() =
        let player = getPlayerString()
        let enemy = getEnemyString()
        match enemy with
        | None -> sprintf "%s" player
        | Some enemy -> sprintf "[\n%s,\n%s\n]" player enemy
    
    let hotkeyManager = HotkeyManager.Current
    
    hotkeyManager.AddOrReplace("DumpGameData", Keys.F11 ||| Keys.Control, (fun _ _ -> Clipboard.SetText(getStrings())))
    printfn "Press Ctrl+F11 with an enemy highlighted to dump to console...\n"

    // Enter message loop
    Application.Run()
    0 // return an integer exit code
