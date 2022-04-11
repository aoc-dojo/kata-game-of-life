namespace Life;

public class Board
{
    private const int CellDead = 0;
    private const int CellAlive = 1;
    private const int DefaultRows = 10;
    private const int DefaultColumns = 10;
    
    public int[,] State { get; private set; }

    public int Rows { get; }

    public int Columns { get; }

    public Board(int[,] initialState)
    {
        throw new NotImplementedException();
    }

    public void Evolve()
    {
        throw new NotImplementedException();
    }

    private int NextStateForCell(int i, int j)
    {
        throw new NotImplementedException();
    }

    private int CalculateLivingNeighbors(int i, int j)
    {
        throw new NotImplementedException();
    }

    private bool IsValid(int[,] arr)
    {
        throw new NotImplementedException();
    }

    protected bool Equals(Board other)
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        throw new NotImplementedException();
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Creates a Board with a random state.
    /// </summary>
    /// <param name="rows"></param>
    /// <param name="columns"></param>
    /// <returns></returns>
    public static Board Random(int rows = DefaultRows, int columns = DefaultColumns)
    {
        throw new NotImplementedException();
    }
}
