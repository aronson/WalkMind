module GL

open System
open Silk.NET.Windowing
open Silk.NET.OpenGL
open System.Drawing
open System.Numerics
open Galante.OpenGL

let glOptions =
    { GlWindowOptions.Default with
        Title = "Cogmind 3D"
        Size = new Size(800, 600) }
