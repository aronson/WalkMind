module Goalfinding

type Config<'a> = { neighbours: 'a -> seq<'a> }

let seekEdge<'a when 'a: comparison> start isUnexplored config : seq<'a> option =

    let rec reconstructPath cameFrom current =
        seq {
            yield current

            match Map.tryFind current cameFrom with
            | None -> ()
            | Some next -> yield! reconstructPath cameFrom next
        }

    let rec crawler openSet visited cameFrom =
        match openSet with
        | [] -> None
        | current :: rest ->
            if isUnexplored current then
                Some <| reconstructPath cameFrom current
            else
                let neighbours =
                    config.neighbours current
                    |> Seq.filter (fun n -> not (Set.contains n visited))
                    |> Seq.toList

                let newCameFrom =
                    neighbours
                    |> List.fold (fun cameFromMap n -> Map.add n current cameFromMap) cameFrom

                let newVisited = visited |> Set.union (Set.ofList neighbours)
                crawler (rest @ neighbours) newVisited newCameFrom

    crawler [ start ] (Set.singleton start) (Map.empty)
