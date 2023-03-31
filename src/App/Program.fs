open App.Movement
open Memory
open AStar
open Goalfinding
open FSharpx.Collections
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
        match x.cell with
        | Domain.cell.NO_CELL -> Seq.empty
        | _ ->
            // There are only up to eight neighbors
            seq {
                yield (AddressCoordinate(x.col - 1, x.row - 1))
                yield (AddressCoordinate(x.col + 1, x.row - 1))
                yield (AddressCoordinate(x.col - 1, x.row + 1))
                yield (AddressCoordinate(x.col + 1, x.row + 1))
                yield (AddressCoordinate(x.col, x.row + 1))
                yield (AddressCoordinate(x.col + 1, x.row))
                yield (AddressCoordinate(x.col, x.row - 1))
                yield (AddressCoordinate(x.col - 1, x.row))
            }
            |> Seq.map (fun x -> magic.tile x)
            //|> Seq.except closedSet
            |> Seq.filter (fun tile ->
                match Model.mapTileOccupancy tile with
                | Model.Occupancy.Vacant -> true
                | Model.Occupancy.Occupied _ -> true
                | _ -> false)

    let config =
        { neighbours = neighbours
          gCost = (fun _ _ -> 1)
          fCost = heuristic
          maxIterations = None }

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
            seekEdge coordinateMap playerTile
            // note: may explode
            |> Option.get
            |> Unexplored

    let formPath start goal =
        let coordinateMap = coordinateMap magic.tiles

        match search start goal config with
        | None -> Error "no path found to goal"
        | Some path -> (Seq.toList path, goal) |> Ok

    let (|TileWithItem|_|) (item: Domain.Item) (tile: LuigiTile) =
        match tile.item with
        | None -> None
        | Some tileItem -> if tileItem.item = item then Some tile else None

    let refEquipmentCount = ref 0

    let scrapYardActions (action: ActionOrchestrator) =
        // take the tiles
        magic.tiles
        // choose tiles with starting equipment
        |> Seq.choose (function
            | TileWithItem Domain.LgtTreads tile
            | TileWithItem Domain.LgtAssaultRifle tile
            | TileWithItem Domain.MedLaser tile
            | TileWithItem Domain.SmlLaser tile
            | TileWithItem Domain.IonEngine tile
            | TileWithItem Domain.LgtIonEngine tile
            | TileWithItem Domain.EmPulseGun tile
            | TileWithItem Domain.AssaultRifle tile -> Some tile
            | _ -> None)
        // Path to those tiles in a lazy sequence
        |> Seq.map (fun itemTile ->
            let playerTile = Model.playerTile magic.tiles

            let itemTile = magic.tile (AddressCoordinate(itemTile.col, itemTile.row))

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
