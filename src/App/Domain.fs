module Domain

open System

type Depth =
    | Scrapyard
    | Mats
    | Factory
    | Research
    | Access

type SpecialFlavor =
    | Extension
    | Scrapyard
    | Hub
    | Exiles
    | Lab
    | Zion
    | Warlord

type DirectionalFlavor =
    | Complex
    | Cave
    | Proxy
    | Mine
    | Prefab of SpecialFlavor

type LevelGenPattern =
    | MinesDrunkenWalk
    | CavesPartitionedDrunkenWalk
    | BinarySpacePartition
    | Scrapyard

type MovementContext = DirectionalFlavor * LevelGenPattern

type PlayerState =
    { core: int
      energy: int
      neuralContext: MovementContext
      timeStamp: int }

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
