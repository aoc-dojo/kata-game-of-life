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

    public override string ToString()
    {
        return $"{nameof(State)}: {State}, {nameof(Rows)}: {Rows}, {nameof(Columns)}: {Columns}";
    }

    public static Board Random(int rows = DefaultRows, int columns = DefaultColumns)
    {
        throw new NotImplementedException();
    }
}
