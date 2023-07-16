# A Cogmind AI project

WalkMind is a project to create an AI that can play the sci-fi roguelike [Cogmind](https://gridsagegames.com/cogmind) by Grid Sage Games.

This repository contains a number of projects geared towards this endeavor. This README goes over their high-level goals.

## WalkMind

An F# console application designed to read Cogmind's memory and press buttons to progress through the game.

## SniffMind

Sniff Mind is an F# library specifically designed for real-time interfacing with Cogmind. Its key features include the ability to attach to a running instance of Cogmind, from where it proceeds to extract valuable gameplay data by directly reading RAM. This encompasses a wide array of details like terrain that has been explored, player statistics, statistics of other in-game robots, as well as items and equipment located either on the ground or in inventories.

The data structures SniffMind reads have been provided by the original author of Cogmind and are vital to bypassing the need for scraping the game's visual data. This functionality ensures that an AI can receive comprehensive updates about the game's state without resorting to intrusive or inefficient methods. The LuigiAI structures can be found on Kyzrati's GitHub [here](https://github.com/Kyzrati/luigiai/tree/main).

Cogmind must be launched with the argument `-luigiAi` to expose these data structures. Note that the capitalization must be exact, with a lowercase `i` at the end.

## DumpMind

An F# console application on the same platform that uses SniffMind to dump Cogmind and an enemy's stats to the clipboard for use with aoemica's [Cog-minder](https://noemica.github.io/cog-minder/simulator.html).

## DataIngest

An internal F# application designed to generate SniffMind's parsing code from the files output to the `Cogmind/luigiAi` folder when running the game in LuigiAI mode.

## LearnMind (coming soon!)

A C# console application providing a learning environment for Cogmind AIs. It provides a framework to:
- launch and manage game sessions
- pass inputs from client AI applications to game instances
- provide the LuigiAI structure data as rich .NET domain types back to client AIs
- manage synchronization of client AI and game input/ready state
- test AI behavior in iterative units that build up to higher level actions (step in a direction, shoot one enemy, assemble a scrapyard build, traverse a mats floor, etc.)
- mock a Cogmind instance through a pre-made data set instead of a live application

## License notes

The initial implementation of AStar.fs is licensed under [WTFGPL](http://www.wtfpl.net/txt/copying/) and adapted to AGPL under a different name

All AGPL code contributed by authors of these commits is additionally licensed under the MIT License to the business entity Grid Sage Games and sole creator of Cogmind where possible. As of writing, this includes all code. This is a fan-made project and the authors of this project are not afilliated with Grid Sage Games.
