open App.Movement
open WalkMind.Memory
open AStar
open Goalfinding
open FSharpx.Collections
open FSharp.Json
open Model

/// We need to wait a little bit before checking magic data if we exited
type PathEnd =
    | Unexplored of LuigiTile
    | Stairs of LuigiTile

/// A state representing our attempt to walk forward in a given step
type WaitLoopState =
    { loopBuster: int
      thisStep: LuigiTile
      nextStep: LuigiTile }

/// A type modeling the result of using input simulator to try to move forward along a path
type WalkResult =
    | Moved
    | Blocked

[<EntryPoint>]
let main args =
    let magic = Memory()

    let distanceBetween (x: LuigiTile) (y: LuigiTile) =
        max (x.row - y.row |> abs) (x.col - y.col |> abs)

    let heuristic (node: LuigiTile) (goal: LuigiTile) = distanceBetween node goal |> float

    let neighbours (x: LuigiTile) =
        match Model.mapTileOccupancy x with
        | Model.Occupancy.Occupied _
        | Model.Occupancy.Obstructed -> Seq.empty
        | _ ->
            match x.cell with
            | WalkMind.Domain.cell.NO_CELL -> Seq.empty
            | _ ->
                // There are only up to eight neighbors
                seq {
                    yield (x.col - 1, x.row - 1)
                    yield (x.col + 1, x.row - 1)
                    yield (x.col - 1, x.row + 1)
                    yield (x.col + 1, x.row + 1)
                    yield (x.col, x.row + 1)
                    yield (x.col + 1, x.row)
                    yield (x.col, x.row - 1)
                    yield (x.col - 1, x.row)
                }
                |> Seq.map (fun coord -> magic.tile (fst coord, snd coord))
                //|> Seq.except closedSet
                |> Seq.filter (fun tile ->
                    match Model.mapTileOccupancy tile with
                    | Model.Occupancy.Vacant -> true
                    | Model.Occupancy.Occupied _ -> true
                    | _ -> false)

    let aStarConfig =
        { neighbours = neighbours
          gCost = (fun _ _ -> 1)
          fCost = heuristic
          maxIterations = None }

    let bfsConfig = { neighbours = neighbours }

    /// It's easier to pull coordinates out in a functional way with a map of (col, row)
    let coordinateMap tiles =
        let coords = tiles |> List.map (fun x -> (x.col, x.row), x)

        Map.ofList coords

    /// This function filters all tiles once in or in FOV to find those with exits using a bad hack
    let exits (tiles: LuigiTile list) =
        tiles
        |> List.filter (function
            | exit when cellToChar exit = ">" -> true
            | _ -> false)

    /// Returns either an Unexplored tile or some Stairs tile
    let goal tiles : PathEnd =
        let playerTile = Model.playerTile tiles
        let coordinateMap = coordinateMap tiles

        match exits tiles with
        | [ exit ] -> Stairs exit
        | exit :: _ -> Stairs exit
        | [] ->
            // No exits, seek nearest Unexplored tile
            seekEdge playerTile (fun tile -> tile.cell = WalkMind.Domain.cell.NO_CELL) bfsConfig
            // note: may explode
            |> Option.get
            |> Seq.head
            |> Unexplored

    let formPath start goal =
        let coordinateMap = coordinateMap magic.tiles

        match search start goal aStarConfig with
        | None -> Error "no path found to goal"
        | Some path -> (Seq.toList path, goal) |> Ok

    let (|TileWithItem|_|) (item: WalkMind.Domain.Item) (tile: LuigiTile) =
        match tile.item with
        | None -> None
        | Some tileItem -> if tileItem.item = item then Some tile else None

    let refEquipmentCount = ref 0

    let json = Json.serialize (Option.get magic.player.entity)
    printfn "%s" json

    let scrapYardActions (action: ActionOrchestrator) =
        // take the tiles
        magic.tiles
        // choose tiles with starting equipment
        |> Seq.choose (function
            | TileWithItem WalkMind.Domain.Item.``Lgt_ Treads`` tile
            | TileWithItem WalkMind.Domain.Item.``Lgt_ Assault Rifle`` tile
            | TileWithItem WalkMind.Domain.Item.``Med_ Laser`` tile
            | TileWithItem WalkMind.Domain.Item.``Sml_ Laser`` tile
            | TileWithItem WalkMind.Domain.Item.``Ion Engine`` tile
            | TileWithItem WalkMind.Domain.Item.``Lgt_ Ion Engine`` tile
            | TileWithItem WalkMind.Domain.Item.``EM Pulse Gun`` tile
            | TileWithItem WalkMind.Domain.Item.``Assault Rifle`` tile -> Some tile
            | _ -> None)
        // Path to those tiles in a lazy sequence
        |> Seq.map (fun itemTile ->
            let playerTile = Model.playerTile magic.tiles

            let itemTile = magic.tile (itemTile.col, itemTile.row)

            match formPath playerTile itemTile with
            | Error message -> raise (System.Exception message)
            | Ok(path, goal) -> path, goal)
        // Start walking to those tiles
        |> Seq.iter (fun (path, goal) ->
            let steps = List.rev path |> List.pairwise
            let stepPairs = List.rev path |> List.pairwise

            let moveOne step = action.execute (Move step) |> ignore

            List.iter moveOne stepPairs
            action.execute (Attach) |> ignore
            refEquipmentCount.Value <- refEquipmentCount.Value + 1
            ())

    // We are LIVE; no more setup functions, this is where the program DOES stuff!
    magic.activateCogmindWindow ()
    // Wait for window to activate (20 ms is probably fine but eh...)
    System.Threading.Thread.Sleep(150)

    let action = ActionOrchestrator(magic)

    // loop until we reach the surface
    while (magic.depth <= -1) do
        (*if (magic.depth = -11 && refEquipmentCount.Value < 5) then
            scrapYardActions action
        elif (magic.depth = -11) then
            let recycler =
                magic.tiles
                |> List.choose (fun t -> t.entity)
                |> List.find (fun e -> e.entity = Domain.entity.R06_Scavenger)

            printfn "Action: %A" (action.execute (Shoot recycler))
            ()*)

        try
            let playerTile = Model.playerTile magic.tiles

            let path =
                formPath
                    playerTile
                    (goal magic.tiles
                     |> function
                         | Unexplored goal
                         | Stairs goal -> goal)

            match path with
            | Error message -> raise (System.Exception <| $"Error forming path :%A{message}")
            | Ok(path, goal) ->
                printPath path goal (magic.mapWidth, magic.mapHeight) magic.tiles

                let stepPairs = List.rev path |> List.pairwise

                let moveOne step = action.execute (Move step) |> ignore

                List.iter moveOne stepPairs
                ()
        with _ ->
            System.Threading.Thread.Sleep(1000)

    ()

    printfn "I'm walking here"
    printfn "Press any key to exit..."
    System.Console.ReadKey() |> ignore
    0
