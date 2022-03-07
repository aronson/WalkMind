module Simulator.Calculator

open Types
open State

let random = new System.Random()
let randomInt min max = (random.Next() % (max + 1 - min)) + min

let minAccuracy = 10
let maxRangedAccuracy = 95
let maxMeleeAccuracy = 100

let maxVolleys = 1000

let mapVolleyTime =
    function
    | value when value = 1 -> 200
    | value when value = 2 -> 300
    | value when value = 3 -> 325
    | value when value = 4 -> 350
    | value when value = 5 -> 375
    | value when value = 6 -> 400
    | _ -> -1

type DamageChunk =
    { armorAnalyzed: bool
      critical: Critical option
      damageType: DamageType
      disruptChance: int
      forceCore: bool
      originalDamage: int
      realDamage: int
      spectrum: int }

let applyDamage
    (state: SimulatorState)
    (botState: BotState)
    (damage: int)
    (critical: Critical option)
    (armorAnalyzed: bool)
    (coreAnalyzed: bool)
    (disruptChance: int)
    (spectrum: int)
    (canOverflow: bool)
    (damageType: DamageType)
    =
    let damageChunks =
        match damageType with
        | Explosive ->
            // Split explosive damage randomly into 1-3 chunks (8)
            // EX damage can never crit, ignore armor, disrupt, explicitly
            // target core, or have a spectrum
            // Note: The remainder from the division is explicitly thrown out
            let numChunks = randomInt 0 2

            seq {
                for _ = 0 to numChunks do
                    yield
                        { armorAnalyzed = false
                          critical = None
                          damageType = damageType
                          disruptChance = 0
                          forceCore = false
                          originalDamage = (damage / numChunks)
                          realDamage = 0
                          spectrum = 0 }
            }
        | _ ->
            seq {
                yield
                    { armorAnalyzed = armorAnalyzed
                      critical = critical
                      damageType = damageType
                      disruptChance = disruptChance
                      forceCore = false
                      originalDamage = damage
                      realDamage = 0
                      spectrum = spectrum }
            }

    let getHitPart (botState: BotState) (damageType: DamageType) (isOverflow: bool) (forceCore: bool) =
        match forceCore with
        | true -> None
        | false ->
            match damageType with
            | Impact when not isOverflow ->
                match randomInt 0 botState.parts.Length with
                | coverageHit when coverageHit < botState.parts.Length -> Some(botState.parts.Item coverageHit)
                | _ -> None
            | _ when isOverflow -> None // TODO: handle overflow protection part selection
            | _ ->
                let coverageHit = randomInt 0 (botState.totalCoverage - 1)

                let rec seekCoverageHit index remainingCoverage =
                    let part = botState.parts.Item index

                    match remainingCoverage - part.coverage with
                    | hit when hit < 0 -> Some part
                    | miss ->
                        if index + 1 = botState.parts.Length then
                            None // core hit, can't hit anything else
                        else
                            seekCoverageHit (index + 1) miss

                seekCoverageHit coverageHit 0

    let applyChunkDamageToPart
        (botState: BotState)
        (damage: int)
        (critical: Critical option)
        (part: SimulatorPart option)
        =
        let doesCritDestroyPart =
            function
            | Some critical ->
                match critical with
                | Destroy
                | Smash -> true
                | _ -> false
            | None -> false

        let destroyPart (part: SimulatorPart) =
            // Remove the destroyed part from the new state
            { botState with
                parts = botState.parts |> List.except (seq { part })
                totalCoverage = botState.totalCoverage - part.coverage
                armorAnalyzedCoverage =
                    botState.armorAnalyzedCoverage
                    - part.armorAnalyzedCoverage }

        let handleCoreHit =
            // Apply the damage
            { botState with coreIntegrity = botState.coreIntegrity - damage }

        match part with
        | None -> handleCoreHit
        | Some part ->
            match part.integrity <= damage
                  || doesCritDestroyPart critical
                with
            | true -> destroyPart part
            | false ->
                let damagedPart =
                    { part with integrity = part.integrity - damage }

                { botState with
                    parts =
                        damagedPart
                        :: (botState.parts |> List.except (seq { part })) }

    let applyDamageChunk
        (botState: BotState)
        (damage: int)
        (critical: Critical option)
        (damageType: DamageType)
        (isOverflow: bool)
        (forceCore: bool)
        =
        let part =
            getHitPart botState damageType isOverflow forceCore

        applyChunkDamageToPart botState damage critical part, part

    let mutable state = botState

    for chunk in damageChunks do
        let (nextState, destroyedPart) =
            applyDamageChunk state chunk.originalDamage critical damageType false false

        match destroyedPart with
        | None -> state <- nextState
        | Some part -> state <- nextState // need to update accuracy in simulation

    state

let updateWeaponsAccuracy (state: SimulatorState) =
    let offensiveState = state.offensiveState
    let botState = state.botState

    // Flying/hovering enemy penalty
    // TODO: Handle bots becoming overweight
    let botDef = botState.def

    let perWeaponBonus =
        match botDef.movement with
        | Flying
        | Hovering -> -10
        | _ -> 0 // TODO: Handle avoid on prop
        |> function
            | bonus when offensiveState.analysis -> bonus + 5
            | bonus -> bonus

    let mutable siegeBonus = 0

    let fullBonus =
        match offensiveState.melee with
        | true ->
            // Add melee analysis bonuses
            let analysisBonus =
                perWeaponBonus
                + List.sum offensiveState.meleeAnalysis
            // TODO: Handle force boost debuff
            let forceBoostBonus = 0
            forceBoostBonus + analysisBonus
        | false ->
            let lowDistanceBonus =
                perWeaponBonus
                + if offensiveState.distance < 6 then
                      (6 - offensiveState.distance) * 3
                  else
                      0
            // TODO: Handle entering siege mode
            siegeBonus <- offensiveState.siegeBonus.bonus
            // TODO: Handle phase shifters
            siegeBonus + lowDistanceBonus

    let updateWeaponAccuracy (weapon: SimulatorWeapon) =
        // Guided weapons always have 100% accuracy
        if weapon.def.waypoints.Length > 0 then
            { weapon with accuracy = 100 }
        else
            // TODO: handle recoil
            let baseAccuracy = weapon.baseAccuracy + fullBonus
            // Cap accuracy
            let maxAccuracy =
                if offensiveState.melee then
                    maxMeleeAccuracy
                else
                    maxRangedAccuracy

            { weapon with accuracy = min maxAccuracy (max baseAccuracy minAccuracy) }

    { state with weapons = state.weapons |> List.map updateWeaponAccuracy }


let rec simulateCombat (state: SimulatorState) (volleys: int) (oldTus: int) = ()
