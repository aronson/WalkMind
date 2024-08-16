# A Cogmind AI project

WalkMind is a project to create an AI that can play the sci-fi roguelike [Cogmind](https://gridsagegames.com/cogmind) by Grid Sage Games.

This repository contains a number of projects geared towards this endeavor. This README goes over their high-level goals.

## WalkMind

WalkMind is an F# console application. Its design facilitates the reading of Cogmind's memory and enables button presses to progress through the game.

## SniffMind

SniffMind is an F# library, purpose-built for real-time interfacing with Cogmind. It boasts key features such as attaching to a live instance of Cogmind, after which it extracts valuable gameplay data directly from RAM. This encompasses a wide array of details like terrain that has been explored, player statistics, statistics of other in-game robots, as well as items and equipment located either on the ground or in inventories.

SniffMind reads data structures provided by Cogmind's author. These are crucial for avoiding the need to scrape the game's visual data, allowing an AI to receive comprehensive updates about the game state without resorting to intrusive or inefficient methods. The LuigiAI structures can be found on Kyzrati's GitHub [here](https://github.com/Kyzrati/luigiai/tree/main).

Cogmind must be launched with the argument `-luigiAi` to expose these data structures. Note that the capitalization must be exact, with a lowercase `i` at the end.

## DumpMind

DumpMind is an F# console application that utilizes SniffMind to dump Cogmind and an enemy's stats onto the clipboard for use with aoemica's [Cog-minder](https://noemica.github.io/cog-minder/simulator.html).

## DataIngest

DataIngest is an internal F# application, designed to generate SniffMind's parsing code. It operates on the files output to the Cogmind/luigiAi folder when the game runs in LuigiAI mode.

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
