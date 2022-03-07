module Simulator.Types

open FSharp.Data
open Magic

type BotSize =
    | Huge
    | Large
    | Medium
    | Small
    | Tiny

type BotResistances =
    { electromagnetic: int
      explosive: int
      impact: int
      kinetic: int
      piercing: int
      slashing: int
      thermal: int }

type ItemOption = { name: string; number: int option }

type BotPart =
    { name: string
      number: int
      coverage: int
      integrity: int }

type Armament =
    | Armament of string
    | ItemOptions of ItemOption array

type Movement =
    | Hovering
    | Flying
    | Treading
    | Walking
    | CorePropulsion
    | Rolling

type Bot =
    { armament: Armament array
      armamentData: BotPart list
      armamentString: string
      ``class``: string
      components: Armament array
      componentData: BotPart list
      componentOptionData: BotPart list list
      componentsString: string
      coreCoverage: int
      coreExposure: int
      coreIntegrity: int
      description: string
      memory: string
      movement: Movement
      name: string
      botSize: BotSize
      profile: string
      rating: string
      resistances: BotResistances
      spotPercent: string
      threat: string
      tier: string
      totalCoverage: int
      traits: string list
      traitsString: string
      value: int
      visualRange: int }

type DamageType =
    | Electromagnetic
    | Entropic
    | Explosive
    | Impact
    | Kinetic
    | Phasic
    | Piercing
    | Slashing
    | Special
    | Thermal

type HeatTransfer =
    | Minimal = 5
    | Low = 25
    | Medium = 37
    | High = 50
    | Massive = 80

type ItemSlot =
    | NoItem
    | Power
    | Propulsion
    | Utility
    | Weapon

type ItemWithUpkeep =
    { energyUpkeep: int option
      matterUpkeep: int option
      heatGeneration: int option }

type ItemType =
    | Artifact
    | BallisticCannon
    | BallisticGun
    | DataCore
    | Device
    | EnergyCannon
    | EnergyGun
    | Engine
    | FlightUnit
    | Hackware
    | HoverUnit
    | ImpactWeapon
    | Item
    | Launcher
    | Leg
    | Matter
    | PiercingWeapon
    | PowerCore
    | Processor
    | Protection
    | Protomatter
    | Reactor
    | Scrap
    | SlashingWeapon
    | SpecialMeleeWeapon
    | SpecialWeapon
    | Storage
    | Trap
    | Treads
    | Wheel

type SiegeMode =
    | High
    | Standard

type Spectrum =
    | Wide = 10
    | Intermediate = 30
    | Narrow = 50
    | Fine = 100

type Critical =
    | Blast
    | Burn
    | Corrupt
    | Destroy
    | Detonate
    | Meltdown
    | Intensify
    | Phase
    | Puncture
    | Smash
    | Sever
    | Sunder

type SpecialPropertyActive =
    | Always
    | PartActive

type Actuator = { amount: int }
type AntimissileChance = { chance: int }
type AvoidChance = { chance: int }
type CoreShielding = { shielding: int }
type CorruptionIgnore = { chance: int }
type DamageReduction = { chance: int }
type DamageResists = { resists: DamageType * int }
type EnergyFilter = { percent: int }
type EnergyStorage = { storage: int }
type FusionCompressor = { energyPerTurn: int }
type HeatDissipation = { dissipation: int }
type MassSupport = { support: int }
type PowerAmplifier = { percent: int }
type PowerShielding = { shielding: int }
type PropulsionShielding = { shielding: int }
type RangedAvoid = { avoid: int }
type RangedWeaponCycling = { amount: int }
type SelfReduction = { shielding: int }
type UtilityShielding = { shielding: int }

type WeaponRegen =
    { energyPerTurn: int
      integrityPerTurn: int }

type WeaponShielding = { shielding: int }

type SpecialPropertyType =
    | Actuator of Actuator
    | AntimissileChance of AntimissileChance
    | AvoidChance of AvoidChance
    | CoreShielding of CoreShielding
    | CorruptionIgnore of CorruptionIgnore
    | DamageReduction of DamageReduction
    | DamageResists of DamageResists
    | EnergyFilter of EnergyFilter
    | EnergyStorage of EnergyStorage
    | FusionCompressor of FusionCompressor
    | HeatDissipation of HeatDissipation
    | MassSupport of MassSupport
    | PowerAmplifier of PowerAmplifier
    | PowerShielding of PowerShielding
    | PropulsionShielding of PropulsionShielding
    | RangedAvoid of RangedAvoid
    | RangedWeaponCycling of RangedWeaponCycling
    | SelfReduction of SelfReduction
    | UtilityShielding of UtilityShielding
    | WeaponRegen of WeaponRegen
    | WeaponShielding of WeaponShielding

type SpecialItemProperty =
    { active: SpecialPropertyActive
      ``trait``: SpecialPropertyType }

type BaseItem =
    { slot: ItemSlot
      hackable: bool
      name: string
      noPrefixName: string
      ``type``: ItemType
      rating: int
      ratingString: string
      size: int
      mass: int
      integrity: int
      coverage: int
      effect: string
      categories: int array
      index: int
      specialProperty: SpecialItemProperty option }

type OtherItem = { life: string option }

type PowerItem =
    { heatGeneration: int
      energyGeneration: int
      energyStorage: int
      powerStability: int }

type PropulsionItem =
    { timePerMove: int
      modPerExtra: int
      drag: int
      energyPerMove: float
      heatPerMove: int
      support: int
      penalty: int
      burnout: string
      siege: SiegeMode }

type UtilityItem = { specialTrait: string }

type WeaponItem =
    { specialTrait: string
      range: int
      shotEnergy: int
      shotHeat: int
      shotMatter: int
      projectileCount: int
      damage: string
      damageMin: int
      damageMax: int
      damageType: DamageType
      spectrum: Spectrum
      disruption: int
      salvage: int
      critical: int
      criticalType: Critical
      criticalString: string
      targeting: int
      penetration: string
      delay: int
      heatTransfer: HeatTransfer
      overloadStability: int
      explosionRadius: int
      explosionDamage: string
      explosionDamageMin: int
      explosionDamageMax: int
      falloff: string
      explosionType: DamageType
      explosionHeatTransfer: HeatTransfer
      arc: int
      mass: int
      waypoints: string
      explosionSpectrum: Spectrum
      explosionDisruption: int
      explosionSalvage: string
      recoil: int
      life: string }

type Item =
    | OtherItem of OtherItem
    | PowerItem of PowerItem * BaseItem
    | PropulsionItem of PropulsionItem * BaseItem
    | UtilityItem of UtilityItem * BaseItem
    | WeaponItem of WeaponItem * BaseItem

type SimulatorPart =
    { armorAnalyzedCoverage: int
      coverage: int
      def: Item
      integrity: int
      protection: bool
      selfDamageReduction: int
      resistances: BotResistances }

type BotState =
    { armorAnalyzedCoverage: int
      coreCoverage: int
      coreDisrupted: bool
      coreIntegrity: int
      corruption: int
      def: Bot
      externalDamageReduction: string
      initialCoreIntegrity: int
      parts: SimulatorPart list
      regen: int
      resistances: BotResistances
      totalCoverage: int }

type SimulatorWeapon =
    { accelerated: bool
      accuracy: int
      baseAccuracy: int
      criticalChance: int
      criticalType: Critical option
      damageMin: int
      damageMax: int
      damageType: DamageType option
      def: WeaponItem
      delay: int
      disruption: int
      explosionMin: int
      explosionMax: int
      isMissle: bool
      numProjectiles: int
      overflow: bool
      overloaded: bool
      spectrum: int }

type Momentum =
    { bonus: int
      current: int
      initial: int }

type SiegeBonus = { bonus: int; tus: int }

type OffensiveState =
    { armorAnalyzerChange: int
      analysis: bool
      chargerBonus: int
      coreAnalyzerChange: int
      distance: int
      followupChanges: int list
      forceBoosters: int list
      melee: bool
      meleeAnalysis: int list
      momentum: Momentum
      numTreads: int
      overloadBonus: int
      ramming: bool
      recoil: int
      recoilReduction: int
      siegeBonus: SiegeBonus
      sneakAttack: bool
      speed: int
      targetingComputerBonus: int
      volleyTime: int
      volleyTimeModifier: int }

type SimulatorState =
    { botState: BotState
      initialBotState: BotState
      killTus: (int * int) list
      killVolleys: (int * int) list
      timeUnits: int
      offensiveState: OffensiveState
      weapons: SimulatorWeapon list }

[<Literal>]
let botSchemaFile = "./robots_export_b11.csv"

[<Literal>]
let itemSchemaFile = "./gallery_export_b11.csv"

type BotProvider = CsvProvider<botSchemaFile>
type ItemProvider = CsvProvider<itemSchemaFile>

let botData = BotProvider.Load botSchemaFile
let itemData = ItemProvider.Load itemSchemaFile
