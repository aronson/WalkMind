namespace App

open Magic

module Shell =
    open Avalonia.Controls
    open Avalonia.FuncUI
    open Avalonia.FuncUI.DSL
    open Avalonia.FuncUI.Hosts
    open GuiState
    open Magic

    let view initialState =
        Component (fun _ ->
            DockPanel.create [
                               DockPanel.children [ TabControl.create [ TabControl.tabStripPlacement Dock.Top
                                                                        TabControl.viewItems [ TabItem.create [ TabItem.header
                                                                                                                    "AI Controls"
                                                                                                                TabItem
                                                                                                                    .content (
                                                                                                                        Counter.view
                                                                                                                            initialState
                                                                                                                    ) ]
                                                                                               TabItem.create [ TabItem.header
                                                                                                                    "About"
                                                                                                                TabItem.content
                                                                                                                    About.view ] ] ] ] ])

    /// This is the main window of your application
    /// you can do all sort of useful things here like setting heights and widths
    /// as well as attaching your dev tools that can be super useful when developing with
    /// Avalonia
    type MainWindow() as this =
        inherit HostWindow()

        do
            base.Title <- "Full App"
            base.Width <- 800.0
            base.Height <- 600.0
            base.MinWidth <- 800.0
            base.MinHeight <- 600.0
            let initialState = { paused = false; magic = Magic()}
            this.Content <- view initialState

//this.VisualRoot.VisualRoot.Renderer.DrawFps <- true
//this.VisualRoot.VisualRoot.Renderer.DrawDirtyRects <- true
