using Life;
using Xunit;
using Life.Tests.TestModels;

namespace Life.Tests;

public class BoardTest
{
    [Fact]
    public void Step_1_Should_Initialize_Board()
    {
        var board = new Board(TestBoards.Board3x3);
        Assert.True(board.Rows == 3);
        Assert.True(board.Columns == 3);
        Assert.Equal(TestBoards.Board3x3, board.State);
    }
    
    [Fact]
    public void Step_2_Should_Initialize_Random_Board()
    {
        var board = Board.Random();
        Assert.True(board.Rows == 10);
        Assert.True(board.Columns == 10);
        
        var customSizedBoard = Board.Random(5, 5);
        Assert.True(customSizedBoard.Rows == 5);
        Assert.True(customSizedBoard.Columns == 5);
    }

    [Fact]
    public void Step_3_Random_Board_Initialized_With_0_Size_Should_Throw()
    {
        Assert.Throws<ArgumentException>(() => Board.Random(0, 0));
    }

    [Fact]
    public void Step_4_Board_Initialized_With_Null_Should_Throw()
    {
        Assert.Throws<ArgumentNullException>(() => new Board(null!));
    }

    [Fact]
    public void Step_5_Invalid_Initial_Board_Should_Throw()
    {
        int[,] arr = { { 0, 0, 0, 0, 1 }, {2, 0, 1, -1, 3} };
        Assert.Throws<ArgumentException>(() => new Board(arr));
    }

    [Fact]
    public void Step_6_Initial_Board_Invalid_Size_Should_Throw()
    {
        var state = new int[0,0];
        Assert.Throws<ArgumentException>(() => new Board(state));
    }

    [Fact]
    public void Step_7_Board_Should_Evolve_To_Correct_State()
    {
        var board = new Board(TestBoards.Board3x3);
        board.Evolve();
        
        board.Print();
        Assert.Equal(TestBoards.Board3x3Evolved1, board.State);
    }
}
