module App.Movement

open WindowsInput
open Magic

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

type ParsedAction = Success | Failure

type ActionOrchestrator(magic: Magic) =
    let inputSimulator = new InputSimulator()

    let walkDirection =
        function
        | One -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD1)
        | Two -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD2)
        | Three -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD3)
        | Four -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD4)
        | Wait -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD5)
        | Six -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD6)
        | Seven -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD7)
        | Eight -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD8)
        | Nine -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD9)
        >> ignore

    let attachItem () =
        inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.VK_A)
        |> ignore

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
    
    member _.execute(action) =
        let performAction() =
            // Before walking, make sure we have focus
            if not (magic.isCogmindForegroundWindow ()) then
                printfn "Lost focus to window, waiting for user input..."
                System.Console.ReadKey() |> ignore
                magic.activateCogmindWindow ()
                System.Threading.Thread.Sleep(150)

            let preActionReadyValue = magic.actionReadyValue
            let wasActionRegistered() =
               match preActionReadyValue <> magic.actionReadyValue with
               | true -> Success
               | false -> Failure
            
            match action with
            | Attach ->
                // try to attach item...
                attachItem ()
                // wait for the game
                System.Threading.Thread.Sleep(17)
                wasActionRegistered ()
            | Move (start, next) ->
                // try to step once...
                takeStep start next
                // wait for the game
                System.Threading.Thread.Sleep(17)
                // try to step again if it didn't work
                match wasActionRegistered() with
                | Success -> Success
                | Failure ->
                    takeStep start next
                    System.Threading.Thread.Sleep(17)
                    wasActionRegistered ()
                |>
                function
                | Success ->
                    // Check if this was the stairs tile, and sleep 10s if it was
                    if isStairs next then System.Threading.Thread.Sleep(10000)
                    Success
                | Failure -> Failure
        // get the next action
        performAction()
