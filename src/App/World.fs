module App.World

type AlertFlavor =
    | Caves
    | Complex

type Depth =
    | Scrapyard
    | Materials
    | Factory
    | Research
    | Access

type Access =
    | Main
    | Branch

type Map =
    | Scrapyard
    | Materials
    | Mines
    | Exiles
    | Storage
    | Factory
    | Wastes
    | LowerCaves
    | UpperCaves
    | Zion
    | DataMiner
    | Warlord
    | Zhirov
    | Research
    | Armory
    | Extension
    | Redacted
    | Access

type Exit = Exit of Access * Depth * AlertFlavor

let mapExit: Map -> Exit =
    function
    | Scrapyard -> Main, Depth.Scrapyard, Complex
    | Materials -> Main, Depth.Materials, Complex
    | Mines -> Branch, Depth.Materials, Caves
    | Exiles -> Branch, Depth.Materials, Caves
    | Storage -> Branch, Depth.Materials, Complex
    | Factory -> Main, Depth.Factory, Complex
    | Wastes -> Branch, Depth.Factory, Caves
    | LowerCaves -> Branch, Depth.Factory, Caves
    | UpperCaves -> Branch, Depth.Factory, Caves
    | Zion -> Branch, Depth.Factory, Caves
    | DataMiner -> Branch, Depth.Factory, Caves
    | Warlord -> Branch, Depth.Factory, Caves
    | Zhirov -> Branch, Depth.Factory, Caves
    | Armory -> Branch, Depth.Factory, Complex
    | Extension -> Branch, Depth.Factory, Complex
    | Research -> Branch, Depth.Research, Complex
    | Redacted -> Branch, Depth.Research, Complex
    | Access -> Branch, Depth.Access, Complex
    >> Exit
