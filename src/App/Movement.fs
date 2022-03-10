module Movement

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

let getDirection (thisTile: LuigiTile) (neighbor: LuigiTile) =
    match (thisTile.col - neighbor.col, thisTile.row - neighbor.row) with
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
