using Life;
using Xunit;
using Life.Tests.TestModels;

namespace Life.Tests;

public class BoardTest
{
    [Theory]
    [MemberData(nameof(TestBoards.BoardScenarios), MemberType = typeof(TestBoards))]
    public void Should_Initialize_Board(int size, int[,] initialState, int[,] evolvedState)
    {
        var board = new Board(initialState);
        Assert.True(board.Rows == size);
        Assert.True(board.Columns == size);
        Assert.Equal(initialState, board.State);
    }

    [Fact]
    public void Board_Initialized_With_Null_Should_Throw()
    {
        Assert.Throws<ArgumentNullException>(() => new Board(null!));
    }

    [Fact]
    public void Random_Board_Initialized_With_0_Size_Should_Throw()
    {
        Assert.Throws<ArgumentException>(() => Board.Random(0, 0));
    }

    [Fact]
    public void Invalid_Initial_Board_Should_Throw()
    {
        int[,] arr = { { 0, 0, 0, 0, 1 }, {2, 0, 1, -1, 3} };
        Assert.Throws<ArgumentException>(() => new Board(arr));
    }

    [Fact]
    public void Initial_Board_Invalid_Size_Should_Throw()
    {
        var state = new int[0,0];
        Assert.Throws<ArgumentException>(() => new Board(state));
    }

    [Fact]
    public void Should_Initialize_Random_Board()
    {
        var board = Board.Random();
        Assert.True(board.Rows == 10);
        Assert.True(board.Columns == 10);
        
        var customSizedBoard = Board.Random(5, 5);
        Assert.True(customSizedBoard.Rows == 5);
        Assert.True(customSizedBoard.Columns == 5);
    }

    [Theory]
    [MemberData(nameof(TestBoards.BoardScenarios), MemberType = typeof(TestBoards))]
    public void Board_Should_Evolve_To_Correct_State(int size, int[,] initialState, int[,] evolvedState)
    {
        var board = new Board(initialState);
        board.Evolve();
        
        board.Print();
        Assert.Equal(evolvedState, board.State);
    }
}
