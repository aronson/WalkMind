open System
open System.IO

type Depth =
    | Scrapyard
    | Mats
    | Factory
    | Research
    | Access

type DirectionalFlavor =
    | Complex
    | Cave
    | Proxy
    | Scrapyard
    | Mine

type LevelGenPattern =
    | MinesDrunkenWalk
    | CavesPartitionedDrunkenWalk
    | BinarySpacePartition
    | Scrapyard

type MovementContext = DirectionalFlavor * LevelGenPattern

type MovementContextProcessor = MovementContextProcessor of (FileInfo -> MovementContext)

type PlayerState = { core: int; energy: int; neuralContext: MovementContext; }

type Directionality =
    | Num9
    | Num8
    | Num7
    | Num6
    | Wait
    | Num4
    | Num3
    | Num2
    | Num1

type 

[<EntryPoint>]
let main args =
    printfn "I'm walking here"
    0
