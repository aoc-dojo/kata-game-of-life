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
        yield return new object[] { 2, Alone.Initial, Alone.Evolved };
        // yield return new object[] { 2, OneNeighbour.Initial, OneNeighbour.Evolved };
        // yield return new object[] { 2, TwoNeighbours.Initial, TwoNeighbours.Evolved };
        // yield return new object[] { 2, ThreeNeighbours.Initial, ThreeNeighbours.Evolved };
        // yield return new object[] { 3, Board3x3, Board3x3Evolved1 };
        // yield return new object[] { 3, Board3x3Evolved1, Board3x3Evolved2 };
        // yield return new object[] { 3, Board3x3Evolved2, Board3x3Evolved3 };
        // yield return new object[] { 10, Board10x10, Board10x10Evolved };
    }

    //                       🤮
    // Happy now? :D
    public static readonly TestCase Alone = new TestCase
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

    //                       🤮
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

    public static readonly TestCase TwoNeighbours = new TestCase
    {
        Initial = new int[,] {
            {1, 1},
            {1, 0}
        },
        Evolved = new int[,] {
            {1, 1},
            {1, 1}
        }, 
    };

    public static readonly TestCase ThreeNeighbours = new TestCase
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