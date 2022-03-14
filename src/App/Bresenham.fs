module Bresenham

open FSharpx.State
open Magic

// http://rosettacode.org/wiki/Bitmap/Bresenham%27s_line_algorithm#F.23
let inline bresenham (x0, y0) (x1, y1) =
    let steep = abs (y1 - y0) > abs (x1 - x0)

    let x0, y0, x1, y1 =
        if steep then
            y0, x0, y1, x1
        else
            x0, y0, x1, y1

    let x0, y0, x1, y1 =
        if x0 > x1 then
            x1, y1, x0, y0
        else
            x0, y0, x1, y1

    let dx, dy = x1 - x0, abs (y1 - y0)
    let s = if y0 < y1 then 1 else -1

    let rec loop e x y =
        state {
            if x <= x1 then
                let! (state: (int * int) list) = getState

                do!
                    if steep then
                        ((y, x) :: state) |> putState
                    else
                        ((x, y) :: state) |> putState

                if e < dy then
                    return! loop (e - dy + dx) (x + 1) (y + s)
                else
                    return! loop (e - dy) (x + 1) y
        }

    let (_, result) = loop (dx / 2) x0 y0 []
    result

let fillLine (x: LuigiTile) (y: LuigiTile) (coordinateMap: Map<int * int, LuigiTile>) : LuigiTile list =
    bresenham (x.col, x.row) (y.col, y.row)
    |> List.map (fun x -> Map.find x coordinateMap)
