module Simulator.Calculator

open Types
open State

let random = new System.Random()
let randomInt min max = random.Next(min, max)

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

let rec applyDamage
    (state: SimulatorState)
    (damage: int)
    (critical: Critical option)
    (armorAnalyzed: bool)
    (coreAnalyzed: bool)
    (disruptChance: int)
    (spectrum: int)
    (canOverflow: bool)
    (damageType: DamageType)
    =
    let botState = state.botState

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

    let rec getHitPart (isOverflow: bool) (forceCore: bool) =
        let rec seekCoverageHit index remainingCoverage =
            let part = botState.parts.Item index

            match remainingCoverage - part.coverage with
            | hit when hit < 0 -> Some part
            | miss ->
                if index + 1 = botState.parts.Length then
                    None // core hit, can't hit anything else
                else
                    seekCoverageHit (index + 1) miss

        match forceCore with
        | true -> None
        | false ->
            match damageType with
            | Impact when not isOverflow ->
                match randomInt 0 botState.parts.Length with
                | coverageHit when coverageHit < botState.parts.Length -> Some(botState.parts.Item coverageHit)
                | _ -> None
            | _ when isOverflow ->
                let protectionParts =
                    botState.parts
                    |> List.filter (fun part -> part.coverage > 0 && part.protection)
                // Handle overflow damage specifically when there's armor
                // overflow into a random armor piece based on coverage
                match protectionParts with
                | [] -> getHitPart false false
                | _ ->
                    let coverageHit =
                        randomInt
                            0
                            (protectionParts
                             |> List.map (fun part -> part.coverage)
                             |> List.sum)

                    seekCoverageHit coverageHit 0
            | _ ->
                let coverageHit = randomInt 0 (botState.totalCoverage - 1)
                seekCoverageHit coverageHit 0

    let applyChunkDamageToPart (damage: int) (part: SimulatorPart option) =
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

    let applyDamageChunk (damage: int) (isOverflow: bool) (forceCore: bool) =
        let part = getHitPart isOverflow forceCore

        applyChunkDamageToPart damage part, part

    let mutable mutState = botState

    for chunk in damageChunks do
        let (nextState, destroyedPart) =
            applyDamageChunk chunk.originalDamage false false

        match destroyedPart with
        | None -> mutState <- nextState
        | Some part -> mutState <- nextState // need to update accuracy in simulation

    { state with botState = mutState }

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


let simulateWeapon (state: SimulatorState) (weapon: SimulatorWeapon) =
    let offensiveState = state.offensiveState

    match offensiveState.ramming with
    | true ->
        let speedPercent =
            (100.0 / (float offensiveState.speed)) * 100.0

        let damageMax =
            min
                ((((10.0 + (float weapon.def.mass)) / 5.0 + 1.0)
                  * (speedPercent / 100.0)
                  * (max (float offensiveState.momentum.current) 1.0)))
                100.0

        let damage = max (randomInt 0 (int damageMax)) 0
        applyDamage state damage None false false weapon.disruption weapon.spectrum weapon.overflow DamageType.Impact
    | false ->
        [ 0 .. weapon.numProjectiles - 1 ]
        |> List.fold
            (fun currentState i ->
                // TODO: Handle antimissle
                match randomInt 0 99 < weapon.accuracy with
                | false -> currentState
                | true when Option.isSome weapon.damageType ->
                    let damage =
                        randomInt weapon.damageMin weapon.damageMax

                    let didCritical =
                        if randomInt 0 99 < weapon.criticalChance then
                            weapon.criticalType
                        else
                            None

                    applyDamage
                        currentState
                        damage
                        didCritical
                        false
                        false
                        weapon.disruption
                        weapon.spectrum
                        weapon.overflow
                        (Option.get weapon.damageType)
                | _ -> currentState)
            state

type CombatEndState =
    | Death of SimulatorState
    | Timeout of SimulatorState

let rec simulateCombat (state: SimulatorState) (volleys: int) (maxTurns: int) =
    // Check exit conditions first
    match state.botState.coreIntegrity with
    | death when death <= 0 -> Death state
    | _ when maxTurns <= state.timeUnits / 100 -> Timeout state
    | _ ->
        let accurateState = updateWeaponsAccuracy state

        let postVolleyState =
            List.fold simulateWeapon accurateState accurateState.weapons

        let timeElapsedState =
            { postVolleyState with timeUnits = state.timeUnits + state.offensiveState.volleyTime }
        // TODO: Handle siege mode transitions
        // TODO: Handle regen
        simulateCombat timeElapsedState (volleys + 1) maxTurns
