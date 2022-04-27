namespace App

open Avalonia.Media

module Counter =
    open Avalonia.FuncUI
    open Avalonia.Controls
    open Avalonia.FuncUI.DSL
    open Avalonia.Layout
    open GuiState

    let view (initialState:GuiState)=
        Component.create (
            "Counter",
            fun ctx ->
                let state = ctx.useState initialState

                DockPanel.create [ DockPanel.verticalAlignment VerticalAlignment.Center
                                   DockPanel.horizontalAlignment HorizontalAlignment.Center
                                   DockPanel.children [ Button.create [ Button.width 64
                                                                        Button.horizontalAlignment
                                                                            HorizontalAlignment.Center
                                                                        Button.horizontalContentAlignment
                                                                            HorizontalAlignment.Center
                                                                        Button.content "Pause/Resume"
                                                                        Button.onClick (fun _ ->
                                                                            {state.Current
                                                                             with paused = not state.Current.paused }
                                                                            |> state.Set)
                                                                        Button.dock Dock.Bottom ]
                                                        TextBlock.create [ TextBlock.dock Dock.Top
                                                                           TextBlock.classes [ "map" ]
                                                                           TextBlock.horizontalAlignment
                                                                               HorizontalAlignment.Center
                                                                           TextBlock.text (
                                                                               Model.printMap
                                                                                   (state.Current.magic.mapWidth,
                                                                                    state.Current.magic.mapHeight)
                                                                                    state.Current.magic.tiles) ] ] ]
        )
