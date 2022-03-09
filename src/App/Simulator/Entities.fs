module Simulator.Entities

open Simulator.Types
open Domain
open Magic

let liftPlayerToBot (player: LuigiEntity) : Bot =
    let defaultResist =
        { electromagnetic = 0
          explosive = 0
          impact = 0
          kinetic = 0
          piercing = 0
          slashing = 0
          thermal = 0 }
    // TODO: Everything
    { components = []
      coreCoverage = 100
      coreExposure = player.exposure
      coreIntegrity = player.integrity
      movement = CorePropulsion
      name = "Cogmind"
      botSize = Medium
      resistances = defaultResist
      totalCoverage = 100 }
