module AStar

open Magic

let rec reconstructPath cameFrom node =
    match Map.find node cameFrom with
    | None -> node :: []
    | value -> node :: reconstructPath cameFrom value

let heuristic node = 1

let distanceBetween (x: LuigiTile) (y: LuigiTile) =
    max (x.row - y.row |> abs) (x.col - y.col |> abs)

let rec update x y oldF oldG oldFrom gValue =
    let keyF = Map.containsKey y oldF
    let keyG = Map.containsKey y oldG
    let keyFrom = Map.containsKey (Some y) oldFrom

    match (keyF, keyG, keyFrom) with
    | (true, _, _) -> update x y (Map.remove y oldF) oldG oldFrom gValue
    | (_, true, _) -> update x y oldF (Map.remove y oldG) oldFrom gValue
    | (_, _, true) -> update x y oldF oldG (Map.remove (Some y) oldFrom) gValue
    | _ ->
        let newFrom = Map.add (Some y) (Some x) oldFrom
        let newG = Map.add y gValue oldG
        // Estimated total distance
        let newF = Map.add y (gValue + (heuristic y)) oldF
        (newF, newG, newFrom)

let rec scan x neighbors openSet closedSet f g from =
    match neighbors with
    | [] -> (openSet, f, g, from)
    | y :: n ->
        if Set.contains y closedSet then
            scan x n openSet closedSet f g from
        else
            let g0 = Map.find x g
            let trialG = g0 + distanceBetween x y

            if Set.contains y closedSet then
                let oldG = Map.find y g

                if trialG < oldG then
                    let (newF, newG, newFrom) = update x y f g from trialG
                    scan x n openSet closedSet newF newG newFrom
                else
                    scan x n openSet closedSet f g from
            else
                let newOpen = Set.add y openSet
                let (newF, newG, newFrom) = update x y f g from trialG
                scan x n newOpen closedSet newF newG newFrom

let bestStep openList score =
    let choice score h best bestValue =
        let v = Map.find h score

        match best with
        | None -> ((Some h), v)
        | x when Some v < Some bestValue -> ((Some h), v)
        | _ -> (best, bestValue)

    let rec bestStep4 openList score best bestValue =
        match openList with
        | [] -> best
        | head :: tail ->
            let pair = choice score head best bestValue

            match pair with
            | (next, nextValue) -> bestStep4 tail score next nextValue

    match openList with
    | [] -> None
    | list -> bestStep4 list score None 0

let neighborNodes (map: Map<int * int, LuigiTile>) (closedSet: LuigiTile seq) (x: LuigiTile) =
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
    |> Seq.map (fun (col, row) -> Map.tryFind (col, row) map)
    |> Seq.choose id
    |> Seq.except closedSet
    |> Seq.filter (fun tile ->
        match Model.mapTileOccupancy tile with
        | Model.Occupancy.Vacant -> true
        | _ -> false)
    |> Seq.toList

let rec aStarStep magic goal closedSet openSet fScore gScore cameFrom =
    match Set.count openSet with
    | 0 -> None
    | _ ->
        let l = Set.toList openSet
        let pt = bestStep l fScore

        if (Some goal) = pt then
            let path = reconstructPath cameFrom (Some goal)
            Some path
        else
            match pt with
            | None -> None
            | Some x ->
                let nextOpen = Set.remove x openSet
                let nextClosed = Set.add x closedSet

                let neighbors =
                    neighborNodes magic (Set.toSeq nextClosed) x


                let (newOpen, newF, newG, newFrom) =
                    scan x neighbors nextOpen nextClosed fScore gScore cameFrom

                aStarStep magic goal nextClosed newOpen newF newG newFrom

let aStar magic start goal =
    // The set of explored nodes
    let closedSet = Set.empty
    // The set of nodes to explore
    let openSet = Set.add start Set.empty

    let fScore =
        Map.add start (heuristic start) Map.empty

    let gScore = Map.add start 0 Map.empty

    let cameFrom = Map.add (Some start) None Map.empty

    aStarStep magic goal closedSet openSet fScore gScore cameFrom
