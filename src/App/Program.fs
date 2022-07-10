open System
open App.Movement
open Magic
open AStar
open Goalfinding
open FSharpx.Collections
open Model
open WindowsInput

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
    let magic = Magic()

    /// It's easier to pull coordinates out in a functional way with a map of (col, row)
    let coordinateMap tiles =
        let coords =
            tiles |> List.map (fun x -> (x.col, x.row), x)

        Map.ofList coords

    /// This function filters all tiles once in or in FOV to find those with exits using a bad hack
    let exits (tiles: LuigiTile list) =
        tiles
        |> List.filter
            (function
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

        match aStar coordinateMap start goal with
        | None -> Error "no path found to goal"
        | Some path -> (List.choose id path, goal) |> Ok

    let (|TileWithItem|_|) (item: Domain.Item) (tile: LuigiTile) =
        match tile.item with
        | None -> None
        | Some tileItem ->
            if tileItem.item = item then
                Some tile
            else
                None

    let refEquipmentCount = ref 0

    let scrapYardActions () =
        // take the tiles
        magic.tiles
        // choose tiles with starting equipment
        |> Seq.choose
            (function
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
        |> Seq.map
            (fun itemTile ->
                let playerTile = Model.playerTile magic.tiles

                let itemTile =
                    magic.tile (AddressCoordinate(itemTile.col, itemTile.row))

                match formPath playerTile itemTile with
                | Error message -> raise (System.Exception message)
                | Ok (path, goal) -> path, goal)
        // Start walking to those tiles
        |> Seq.iter
            (fun (path, goal) ->
                let steps = List.rev path |> List.pairwise
                refEquipmentCount.Value <- refEquipmentCount.Value + 1
                ())

    // We are LIVE; no more setup functions, this is where the program DOES stuff!
    // Wait for window to activate (20 ms is probably fine but eh...)
    System.Threading.Thread.Sleep(150)
    
    printfn "Reading bot memory... press any key to sample"
    // loop until we reach the surface
    while true do
        printfn $"{DateTime.Now}"
        let occupiedTiles = magic.tiles |> List.where(
            fun tile ->
            match tile.entity with
            | Some entity -> true
            | None -> false)
        occupiedTiles |> List.iter(fun tile -> printfn $"{tile}")
        printfn "Press any key to sample..."
        System.Console.ReadKey() |> ignore
    ()

    printfn "I'm walking here"
    printfn "Press any key to exit..."
    System.Console.ReadKey() |> ignore
    0
