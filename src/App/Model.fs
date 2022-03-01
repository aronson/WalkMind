module Model

enum WallOrFloor =
| Earth = 0
| Access = 1
| Research = 2
| ResearchBranch = 3
| Caves = 4
| Factory = 5
| Mines = 6
| Materials = 7
| Scrapyard = 8
| Floor = 9
| Debris = 10

enum ItemType =
// only item that matters
| Hammer = 1
| EverythingElse = 2

type Item = {
  kind: ItemType,
  integrity: int
}

enum RobotModel =
| Grunt = 1
| Serf = 2
| Sentry = 3
// etc...
| A8 = 35
| Arch = 36

type Disposition =
| Friendly
| Hostile
// etc...
| Broken
| Disabled

type Robot = {
  hostile: boolean
  model: RobotModel
  disposition: Disposition
  core: int
  loadout: Item array // max 26?
}

type tile = {
  background: WallOrFloor
  item: Item option
  robot: Robot option
}

type tiles = tile array // 160 x 90 elements from left to right, top to bottom, may vary with screen size