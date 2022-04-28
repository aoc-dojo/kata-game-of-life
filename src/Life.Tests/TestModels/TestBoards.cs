namespace Life.Tests.TestModels;

public class TestCase
{
    public int[,] Initial { get; set; }
    public int[,] Evolved { get; set; }
}

public static class TestBoards
{
    public static IEnumerable<object[]> BoardScenarios()
    {
        yield return new object[] { 2, Alone1.Initial, Alone1.Evolved };
        yield return new object[] { 2, Alone2.Initial, Alone2.Evolved };
        yield return new object[] { 2, OneNeighbour.Initial, OneNeighbour.Evolved };
        yield return new object[] { 3, TwoNeighbours1.Initial, TwoNeighbours1.Evolved };
        yield return new object[] { 2, ThreeNeighbours1.Initial, ThreeNeighbours1.Evolved };
        yield return new object[] { 3, ThreeNeighbours2.Initial, ThreeNeighbours2.Evolved };
        yield return new object[] { 3, Board3x3, Board3x3Evolved1 };
        yield return new object[] { 3, Board3x3Evolved1, Board3x3Evolved2 };
        yield return new object[] { 3, Board3x3Evolved2, Board3x3Evolved3 };
        yield return new object[] { 10, Board10x10, Board10x10Evolved };
    }

    public static readonly TestCase Alone1 = new TestCase
    {
        Initial = new int[,] {
            {1, 0},
            {0, 0}
        },
        Evolved = new int[,] {
            {0, 0},
            {0, 0}
        }, 
    };

    public static readonly TestCase Alone2 = new TestCase
    {
        Initial = new int[,] {
            {0, 1},
            {0, 0}
        },
        Evolved = new int[,] {
            {0, 0},
            {0, 0}
        }, 
    };

    public static readonly TestCase Alone3 = new TestCase
    {
        Initial = new int[,] {
            {0, 0},
            {1, 0}
        },
        Evolved = new int[,] {
            {0, 0},
            {0, 0}
        }, 
    };

    public static readonly TestCase OneNeighbour = new TestCase
    {
        Initial = new int[,] {
            {1, 1},
            {0, 0}
        },
        Evolved = new int[,] {
            {0, 0},
            {0, 0}
        }, 
    };

    public static readonly TestCase TwoNeighbours1 = new TestCase
    {
        Initial = new int[,] {
            {0, 0, 1},
            {0, 1, 0},
            {1, 0, 0}
        },
        Evolved = new int[,] {
            {0, 0, 0},
            {0, 1, 0},
            {0, 0, 0}
        }, 
    };

    public static readonly TestCase ThreeNeighbours1 = new TestCase
    {
        Initial = new int[,] {
            {1, 1},
            {1, 1}
        },
        Evolved = new int[,] {
            {1, 1},
            {1, 1}
        }, 
    };

    public static readonly TestCase ThreeNeighbours2 = new TestCase
    {
        Initial = new int[,] {
            {1, 0, 0},
            {1, 0, 0},
            {0, 0, 1}
        },
        Evolved = new int[,] {
            {0, 0, 0},
            {0, 1, 0},
            {0, 0, 0}
        },
    };

    public static readonly int[,] Board3x3 =
    {
        {1, 1, 1},
        {1, 1, 1},
        {0, 0, 1},
    };

    public static readonly int[,] Board3x3Evolved1 =
    {
        {1, 0, 1},
        {1, 0, 0},
        {0, 0, 1},
    };

    public static readonly int[,] Board3x3Evolved2 =
    {
        {0, 1, 0},
        {0, 0, 0},
        {0, 0, 0},
    };

        public static readonly int[,] Board3x3Evolved3 =
    {
        {0, 0, 0},
        {0, 0, 0},
        {0, 0, 0},
    };

    public static readonly int[,] Board10x10 =
    {
        {1, 1, 1, 1, 0, 1, 1, 0, 0, 0},
        {1, 1, 1, 1, 0, 1, 1, 0, 0, 0},
        {0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
        {0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 0, 0, 0, 0, 0, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 0, 0, 1, 1}
    };

    public static readonly int[,] Board10x10Evolved =
    {
        {1, 0, 0, 1, 0, 1, 1, 0, 0, 0},
        {1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
        {1, 0, 0, 1, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
        {0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {1, 1, 0, 0, 0, 0, 0, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 0, 0, 1, 1}
    };
}