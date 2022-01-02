namespace ContextProcessor

open System
open System.IO
open Domain
open FSharp.Data
open State


module ContextProcessor =

    [<Literal>]
    let scoresheetSchema =
        "https://cogmind-api.gridsagegames.com/scoresheets/aj8XgMNb2L9cUDo5s.json"

    type GameState = JsonProvider<scoresheetSchema>

    let dumpDir = new DirectoryInfo("~/dump")

    let getLatestDump () =
        Directory.EnumerateFiles(dumpDir.FullName, "*.json")
        |> Seq.last
        |> GameState.Load

    type NeuralPreProcessor = GameState.Root -> MovementContext

    // TODO: Expects a GameState.Header.RunEndTime, I think? Follow up that it actually mutates
    let rec pollNextDump (neuralPreProcessor: NeuralPreProcessor) (lastStamp: int) =
        let currentDump = getLatestDump ()

        if currentDump.Header.RunEndTime > lastStamp then
            { core = currentDump.Cogmind.CoreIntegrity.Current
              energy = currentDump.Cogmind.Energy.Current
              neuralContext = neuralPreProcessor currentDump
              timeStamp = currentDump.Header.RunEndTime }
        else
            pollNextDump neuralPreProcessor lastStamp


    let processIterations (neuralPreProcessor: NeuralPreProcessor) (neuralProcessor: PlayerState -> Directionality) =
        state {
            let! (last: PlayerState) = State.get

            // parse state with neuralProcessor
            let nextDirection = neuralProcessor last

            // process actions here with AHK somehow

            // Wait until the game emits state
            let next =
                pollNextDump neuralPreProcessor last.timeStamp

            // Satisfy the next poor sap
            do! State.put (next)
        }
        |> State.run
