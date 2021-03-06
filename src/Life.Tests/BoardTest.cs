using Life;
using Xunit;
using Life.Tests.TestModels;

namespace Life.Tests;

[Collection("Board Initialization")]
public class Constructor
{
    [Fact(DisplayName = "The board should receive an initial state.")]
    public void NullInitialState_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => new Board(null!));
    }

    [Fact(DisplayName = "The board initial state should be bigger than a 0x0 matrix.")]
    public void ZeroSizedInitialState_ThrowsArgumentException()
    {
        var state = new int[0,0];
        Assert.Throws<ArgumentException>(() => new Board(state));
    }

    [Fact(DisplayName = "The board initial state cells should have one of two states, 1 (alive) or 0 (dead)")]
    public void InitialBoardStateWithInvalidStates_ThrowsArgumentException()
    {
        int[,] arr = { { 0, 3 }, { 2, -1 } };
        Assert.Throws<ArgumentException>(() => new Board(arr));
    }

    [Theory]
    [MemberData(nameof(TestBoards.BoardScenarios), MemberType = typeof(TestBoards))]
    public void ValidInitialState_ShouldInitializeBoardState(int size, int[,] initialState, int[,] evolvedState)
    {
        var board = new Board(initialState);
        Assert.True(board.Rows == size);
        Assert.True(board.Columns == size);
        Assert.Equal(initialState, board.State);
    }
}

[Collection("Board Generation")]
public class Random
{
    [Fact(DisplayName = "Can only initialize a board bigger than 0x0")]
    public void ZeroAndZero_ThrowsArgumentExcpetion()
    {
        Assert.Throws<ArgumentException>(() => Board.Random(0, 0));
    }

    [Fact(DisplayName = "When no size is defined, initializes a 10x10 board")]
    public void NoArguments_ReturnsA10x10Board()
    {
        var board = Board.Random();

        Assert.True(board.Rows == 10);
        Assert.True(board.Columns == 10);
    }

    [Fact(DisplayName = "When a size is passed in, initializes a board of that size")]
    public void FiveAndFive_ReturnsA5x5Board()
    {
        var customSizedBoard = Board.Random(5, 5);

        Assert.True(customSizedBoard.Rows == 5);
        Assert.True(customSizedBoard.Columns == 5);
    }
}

[Collection("Board Evolution")]
public class Evolve
{
    [Theory]
    [MemberData(nameof(TestBoards.BoardScenarios), MemberType = typeof(TestBoards))]
    public void CalculatesTheNextStateForTheBoard(int size, int[,] initialState, int[,] evolvedState)
    {
        var board = new Board(initialState);
        board.Evolve();
        
        board.Print();
        Assert.Equal(evolvedState, board.State);
    }
}
