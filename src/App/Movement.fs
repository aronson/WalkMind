module App.Movement

open GregsStack.InputSimulatorStandard
open FSharp.Core
open Memory

type NumpadDirection =
    | One
    | Two
    | Three
    | Four
    | Wait
    | Six
    | Seven
    | Eight
    | Nine

type Action =
    | Move of LuigiTile * LuigiTile
    | Attach
    | Shoot of LuigiEntity

type ActionResult =
    | Success
    | Failure

type ActionOrchestrator(magic: Memory) =
    let inputSimulator = new InputSimulator()

    let walkDirection direction =
        let keyCode =
            match direction with
            | One -> Native.VirtualKeyCode.NUMPAD1
            | Two -> Native.VirtualKeyCode.NUMPAD2
            | Three -> Native.VirtualKeyCode.NUMPAD3
            | Four -> Native.VirtualKeyCode.NUMPAD4
            | Wait -> Native.VirtualKeyCode.NUMPAD5
            | Six -> Native.VirtualKeyCode.NUMPAD6
            | Seven -> Native.VirtualKeyCode.NUMPAD7
            | Eight -> Native.VirtualKeyCode.NUMPAD8
            | Nine -> Native.VirtualKeyCode.NUMPAD9

        inputSimulator.Keyboard.KeyPress(keyCode) |> ignore

    let attachItem () =
        inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.VK_A) |> ignore

    let fire () =
        inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.VK_F) |> ignore

    let tab () =
        inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.TAB) |> ignore

    let getDirection (thisTile: LuigiTile) (neighbor: LuigiTile) =
        match (thisTile.row - neighbor.row, thisTile.col - neighbor.col) with
        | (1, -1) -> One
        | (0, -1) -> Two
        | (-1, -1) -> Three
        | (1, 0) -> Four
        | (0, 0) -> Wait
        | (-1, 0) -> Six
        | (1, 1) -> Seven
        | (0, 1) -> Eight
        | (-1, 1) -> Nine
        | _ -> raise (System.ArgumentException("getDirection passed non neighbor tiles!"))

    let takeStep step next = getDirection step next |> walkDirection

    /// Filters a tile for if it's stairs interesting in Materials
    let isStairs tile =
        match tile.cell with
        | Domain.cell.STAIRS_SCR
        | Domain.cell.STAIRS_MAT
        | Domain.cell.STAIRS_MIN
        | Domain.cell.STAIRS_STO -> true
        | _ -> false

    let waitForAction (completionDelay: int) action =
        action ()
        System.Threading.Thread.Sleep(completionDelay)

    let rec performAction retries action checkCompletion =
        if retries <= 0 then
            Error "Retried a command too many times!"
        else
            waitForAction 50 action

            checkCompletion ()
            |> Result.bind (fun _ -> performAction (retries - 1) action checkCompletion)

    member _.execute(action) =
        let wasActionRegistered preActionReadyValue =
            if preActionReadyValue <> magic.actionReadyValue then
                Ok()
            else
                Error "ActionReady not triggered"

        let performActionWithFocus () =
            if not (magic.isCogmindForegroundWindow ()) then
                printfn "Lost focus to window, waiting for user input..."
                System.Console.ReadKey() |> ignore
                magic.activateCogmindWindow ()
                System.Threading.Thread.Sleep(150)

            let preActionReadyValue = magic.actionReadyValue

            let checkCompletion () = wasActionRegistered preActionReadyValue

            match action with
            | Attach -> performAction 2 attachItem checkCompletion
            | Move(start, next) ->
                performAction 2 (fun () -> takeStep start next) checkCompletion
                |> Result.bind (fun _ ->
                    if isStairs next then
                        System.Threading.Thread.Sleep(10000)

                    Ok())
            | Shoot entity ->
                let enemyTile =
                    magic.tiles
                    |> List.find (fun tile ->
                        match tile.entity with
                        | Some otherEntity -> entity = otherEntity
                        | None -> false)

                let result = performAction 1 fire checkCompletion

                let mutable reticuleTile = magic.tiles.[magic.mapCursorIndex]

                while reticuleTile <> enemyTile do
                    tab ()
                    System.Threading.Thread.Sleep(100)
                    reticuleTile <- magic.tiles.[magic.mapCursorIndex]

                Result.bind (fun _ -> performAction 1 fire checkCompletion) result

        // get the next action
        performActionWithFocus ()
