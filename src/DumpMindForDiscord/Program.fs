open System.Threading
open System.Timers
open DiscordRPC
open DiscordRPC.Logging
open WalkMind.Domain
open WalkMind.Memory
open WalkMind.Model

let client = new DiscordRpcClient("914720093701832724")

let memory = Memory()

let getState () =
    let maxCore =
        match memory.depth with
        | -11
        | -10 -> 250
        | d when d >= -9 && d <= -1 -> 250 + (150 * (-d - 8))
        | _ -> failwith "Invalid depth"

    let coreRemainingPercentage = memory.player.entity.Value.integrity / maxCore * 100

    match coreRemainingPercentage with
    | x when x <= 100 -> "Pristine"
    | x when x <= 75 -> "Decent"
    | x when x <= 50 -> "Fine"
    | x when x <= 25 -> "OK"
    | x when x <= 5 -> "Greed"
    | _ -> "u dead fr"

let getPropType () =
    let parseItem (item: LuigiItem) =
        match itemToCategory item.item with
        | Propulsion propulsion -> Some propulsion
        | _ -> None

    let props = List.choose parseItem memory.player.entity.Value.inventory

    let mostCommon (propulsions: Propulsion list) =
        let counts =
            propulsions
            |> List.groupBy id
            |> List.map (fun (prop, items) -> prop, List.length items)

        let sortedCounts = List.sortByDescending snd counts
        fst (List.head sortedCounts)

    if List.length props = 0 then
        "coggy"
    else
        match mostCommon props with
        | Flight -> "go_flight"
        | Hover -> "go_hover"
        | Wheel -> "go_wheels"
        | Legs -> "go_legs"
        | Treads -> "go_treads"

let getPresence () =
    let map =
        sprintf "Current map: %i/%s"
        <| memory.depth
        <| match memory.mapType with
           | MapType.MAP_NONE -> "None"
           | MapType.MAP_SAN -> "Sandbox"
           | MapType.MAP_SCR -> "Junkyard"
           | MapType.MAP_MAT -> "Materials"
           | MapType.MAP_FAC -> "Factory"
           | MapType.MAP_RES -> "Research"
           | MapType.MAP_ACC -> "Access"
           | MapType.MAP_SUR -> "Surface"
           | MapType.MAP_MIN -> "Mines"
           | MapType.MAP_EXI -> "Exiles"
           | MapType.MAP_STO -> "Storage"
           | MapType.MAP_REC -> "Recycling"
           | MapType.MAP_WAS -> "Wastes"
           | MapType.MAP_GAR -> "Garrison"
           | MapType.MAP_DSF -> "DSF"
           | MapType.MAP_SUB -> "Subcaves"
           | MapType.MAP_LOW -> "Lower Caves"
           | MapType.MAP_UPP -> "Upper Caves"
           | MapType.MAP_PRO -> "Proxy Caves"
           | MapType.MAP_DEE -> "Deep Caves"
           | MapType.MAP_ZIO -> "Zion"
           | MapType.MAP_DAT -> "Data Miner"
           | MapType.MAP_ZHI -> "Zhirov"
           | MapType.MAP_WAR -> "Warlord"
           | MapType.MAP_EXT -> "Extension"
           | MapType.MAP_CET -> "Cetus"
           | MapType.MAP_ARC -> "Archives"
           | MapType.MAP_HUB -> "Hub_04(d)"
           | MapType.MAP_ARM -> "Armory"
           | MapType.MAP_LAB -> "Lab"
           | MapType.MAP_QUA -> "Quarantine"
           | MapType.MAP_TES -> "Testing"
           | MapType.MAP_SEC -> "Section 7"
           | MapType.MAP_COM -> "Command"
           | MapType.MAP_AC0 -> "Access 0"
           | MapType.MAP_LAI -> "Lair"
           | MapType.MAP_TOW -> "Wartown"
           | MapType.MAP_W00 -> "w0"
           | MapType.MAP_W01 -> "w1"
           | MapType.MAP_W02 -> "w2"
           | MapType.MAP_W03 -> "w3"
           | MapType.MAP_W04 -> "w4"
           | MapType.MAP_W05 -> "w5"
           | MapType.MAP_W06 -> "w6"
           | MapType.MAP_W07 -> "w7"
           | MapType.MAP_W08 -> "w8"
           | _ -> failwith "unknown map type"

    let status = getState ()

    RichPresence(
        Details = sprintf "%s" map,
        State = sprintf "Current state: %s" status,
        Assets =
            Assets(LargeImageKey = "cogmind_logo", LargeImageText = "Cogmind b13 X1", SmallImageKey = getPropType ())
    )

[<EntryPoint>]
let main _ =
    client.Logger <- ConsoleLogger(Level = LogLevel.Warning)
    client.OnReady.Add(fun message -> printfn "Received Ready from user %s" message.User.Username)
    client.OnPresenceUpdate.Add(fun message -> printfn "Received Update! %s" message.Presence.Details)
    client.Initialize() |> ignore

    let mutable actionReady = -1

    while true do
        (Thread.Sleep(5000)

         if actionReady = memory.actionReadyValue then
             ()
         else
             client.SetPresence(getPresence ())
             actionReady <- memory.actionReadyValue)

    client.Dispose()
    0 // return an integer exit code
