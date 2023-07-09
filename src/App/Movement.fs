module App.Movement

open GregsStack.InputSimulatorStandard
open FSharp.Core
open WalkMind.Memory

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

let keyCode =
    function
    | One -> Native.VirtualKeyCode.NUMPAD1
    | Two -> Native.VirtualKeyCode.NUMPAD2
    | Three -> Native.VirtualKeyCode.NUMPAD3
    | Four -> Native.VirtualKeyCode.NUMPAD4
    | Wait -> Native.VirtualKeyCode.NUMPAD5
    | Six -> Native.VirtualKeyCode.NUMPAD6
    | Seven -> Native.VirtualKeyCode.NUMPAD7
    | Eight -> Native.VirtualKeyCode.NUMPAD8
    | Nine -> Native.VirtualKeyCode.NUMPAD9

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
