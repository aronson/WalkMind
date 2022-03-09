module Movement

open WindowsInput

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
    | One -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD0)
    | Two -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD1)
    | Three -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD2)
    | Four -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD3)
    | Wait -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD4)
    | Six -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD5)
    | Seven -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD6)
    | Eight -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD7)
    | Nine -> inputSimulator.Keyboard.KeyPress(Native.VirtualKeyCode.NUMPAD8)
