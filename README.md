# SolidTacToe

An C#/.NET attempt at a completely [SOLID][1] implementation of Tic Tac Toe, as mentioned on [episode #7][2] of the Coding Blocks Podcast.

Available under the [MIT License][3]

## Solution Layout

### [SolidTacToe][4]

Library that models the game TicTacToe. Only contains the "business" logic behind the game, contains nothing for interacting with users.

#### [SolidTacToe.Definitions][5]
Public interfaces used throughout the library. These are the only abstractions upon which you should depend.

#### [SolidTacToe.Factories][6]
Factories for creating and intializing basic game state.

#### [SolidTacToe.GameOverConditions][7]
Classes that represent the various states of the game after each turn.

#### [SolidTacToe.Moves][8]
Contains logic for making moves and keeping track of the current move maker.

### [SolidTacToe.Exe][9]
Contains a basic console application that demonstratates how to use the SolidTacToe Library.

#### [SolidTacToe.Exe.Definitions][10]
Internal interfaces that are specific to console application.

#### [SolidTacToe.Exe.Rendering][11]
Here lies the code for drawing the game state to screen.

### SolidTacToe.Exe.Tests
Test code for the SolidTacToe project. Does NOT test SolidTacToe.Exe.

Documentation is available for each namespace (excluding tests) in the _readme.md file of each folder.

[1]: http://en.wikipedia.org/wiki/SOLID_(object-oriented_design)
[2]: http://www.codingblocks.net/podcast/episode-7-solid-as-a-rock/
[3]: https://github.com/codingblocks/SolidTacToe/LICENSE.txt
[4]: https://github.com/codingblocks/SolidTacToe/tree/master/SolidTacToe/_readme.md
[5]: https://github.com/codingblocks/SolidTacToe/tree/master/SolidTacToe/Definitions/_readme.md
[6]: https://github.com/codingblocks/SolidTacToe/tree/master/SolidTacToe/Factories/_readme.md
[7]: https://github.com/codingblocks/SolidTacToe/tree/master/SolidTacToe/GameOverConditions/_readme.md
[8]: https://github.com/codingblocks/SolidTacToe/tree/master/SolidTacToe/Moves/_readme.md
[9]: https://github.com/codingblocks/SolidTacToe/tree/master/SolidTacToe.Exe/_readme.md
[10]: https://github.com/codingblocks/SolidTacToe/tree/master/SolidTacToe.Exe/Definitions/_readme.md
[11]: https://github.com/codingblocks/SolidTacToe/tree/master/SolidTacToe.Exe/Rendering/_readme.md