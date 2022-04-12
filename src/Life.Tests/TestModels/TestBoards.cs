namespace Life.Tests.TestModels;

public static class TestBoards
{
    public static IEnumerable<object[]> BoardScenarios()
    {
        yield return new object[] { 3, Board3x3, Board3x3Evolved1 };
        // yield return new object[] { 3, Board3x3Evolved1, Board3x3Evolved2 };
        // yield return new object[] { 3, Board3x3Evolved2, Board3x3Evolved3 };
        // yield return new object[] { 10, Board10x10, Board10x10Evolved };
    }

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