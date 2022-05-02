# Kata: Game of Life

Adapted from https://github.com/jkratz55/game-of-life-kata

This Kata is about calculating the next generation of Conway’s Game of Life, 
given any starting state. 

You start with a two dimensional grid of cells, where each cell is either alive or dead. 
In this version of the problem, the grid is finite, and no life can exist off the edges. 
When calculating the next generation of the grid, follow these rules:

1. Any live cell with fewer than two live neighbours dies (referred to as underpopulation or exposure).
2. Any live cell with more than three live neighbours dies (referred to as overpopulation or overcrowding).
3. Any live cell with two or three live neighbours lives, unchanged, to the next generation.
4. Any dead cell with exactly three live neighbours will come to life.

The code should allow for the board/world to be created with a valid initial state, or a randomly
generated state.

## Pre-requisites
### VS Code Dev Container

The recommended setup for most people is to use the VS Code dev container feature. That way required frameworks and extensions are installed automatically.

* [git](https://git-scm.com/downloads)
* [VS Code](https://code.visualstudio.com/Download)
* [Docker Desktop](https://www.docker.com/products/docker-desktop/)
  * Can also be auto-installed via a VS Code prompt

### Local developer environment
If you are already comfortable with .NET development and prefer to use a pre-existing local setup, the `kata-game-of-life.sln` file can be opened in a .NET IDE such as Visual Studio or Rider. Make sure tools are up-to-date since this project uses the newest .NET 6 platform.

## Dev Container Quick Start
1. Open VS Code.
2. On the get started screen, hit "clone from git repository".
3. Enter this repository's URL and clone.
4. Install the `Remote - Containers` extension if it isn't already. VS Code should recommend it in a prompt, or it can be found in the recommended section of the extensions tab.
5. A prompt should ask if you want to open the workspace in a dev container - say yes. If there's no prompt, you can use the green button on the bottom left of VS Code (a shorcut for remote connection commands), and run the "Open Folder in Container" command.
6. Wait for the container to build, it can take a minute.
7. Workspace should open in the container, to test you can open a new terminal (Terminal->New Terminal) and run `dotnet build`

You should now be able to run the tests through one of two methods:

* Open the `src/Life.Tests/BoardTest.cs` test file, and click the "Run Test" button above a test
* Run `dotnet watch test --project src/Life.Tests/Life.Tests.csproj` in a terminal

## Kata Outline

The goal of this kata is to implement the `Board` class, in the `src/Life/Board.cs` source file. A skeleton of this class is in place but needs to be implemented. Unit tests in `src/Life.Tests/BoardTest.cs` will track your progress.

### Implement constructor

The first couple tests deal with initialization of the `Board` class using its constructor. The constructor should:

* Populate the class properties
* Throw an `ArgumentNullException` if the given board state is `null`
* Throw an `ArgumentException` if the given board state is less than 1x1 in size
* Throw an `ArgumentException` if the given board state contains any values other than `CellAlive` or `CellDead`

### Implement `Board.Random`

A helper static method that returns a board initialized from a random state.

### Implement `Board.Evolve`

The Game of Life logic is implemented in the `Evolve` method. Calling the `Evolve` method should advance `State` to the next generation, following the rules described in the introduction. The method will check each cell to see if it will live or die in the next generation based on the number of neighbours.

### Enable more board scenarios

Once you have things working well for the first scenario, you can go to the `src/Life.Tests/TestModels/TestBoards.cs` to enable more scenarios.

In the method `BoardScenarios`, there are two more 3x3 boards you can enable. There is also one 10x10 scenario to test at a higher dimension.
