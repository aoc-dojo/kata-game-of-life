namespace Life;

public class Board
{
    private const int CellDead = 0;
    private const int CellAlive = 1;
    private const int DefaultRows = 10;
    private const int DefaultColumns = 10;

    private const int RowDimensionIndex = 0;
    private const int ColDimensionIndex = 1;
    
    public int[,] State { get; private set; }

    public int Rows => State.GetLength(RowDimensionIndex);
    public int Columns => State.GetLength(ColDimensionIndex);

    public Board(int[,] initialState)
    {
        ArgumentNullException.ThrowIfNull(initialState);

        var rowCount = initialState.GetLength(RowDimensionIndex);
        var colCount = initialState.GetLength(ColDimensionIndex);
        
        if (rowCount is 0 || colCount is 0)
            throw new ArgumentException();

        for (int i = 0; i < rowCount; i++)
            for (int j = 0; j < colCount; j++) 
                if(!CellIsValid(initialState[i, j])) throw new ArgumentException();

        State = initialState;
    }


    public void Evolve()
    {
        var newState = new int[Rows, Columns];
        for (int i = 0; i < Rows; i++)
        for (int j = 0; j < Columns; j++) 
        {
            var numberOfNeighbours = GetNumberOfAliveNeighbours(i, j);

            switch (numberOfNeighbours) {
                case 2:
                    newState[i, j] = State[i, j];
                    break;
                case 3:
                    newState[i, j] = CellAlive;
                    break;
                default:
                    newState[i, j] = CellDead;
                    break;
            }
        }

        State = newState;
    }

    private int GetNumberOfAliveNeighbours(int row, int column) {
        int numberOfNeighbours = 0;

        var rowBoundaries = new [] {-1, 0, 1};
        var columnBoundaries = new [] {-1, 0, 1};

        foreach(var rowIndexModifier in rowBoundaries)
        foreach(var colIndexModifier in columnBoundaries)
        {
            var rowToSearch = row + rowIndexModifier;
            if (rowToSearch < 0 || rowToSearch >= Rows)
            {
                continue;
            }

            var colToSearch = column + colIndexModifier;
            var isSameItem = colToSearch == column && rowToSearch == row;

            if (colToSearch < 0 || colToSearch >= Columns || isSameItem)
            {
                continue;
            }

            numberOfNeighbours += State[rowToSearch, colToSearch];
        }

        return numberOfNeighbours;
    }

    public override string ToString()
    {
        return $"{nameof(State)}: {State}, {nameof(Rows)}: {Rows}, {nameof(Columns)}: {Columns}";
    }

    public static Board Random(int rows = DefaultRows, int columns = DefaultColumns)
    {
        if (rows is 0 || columns is 0)
            throw new ArgumentException();

        var state = new int[rows, columns];
        return new Board(state);
    }

    private bool CellIsValid(int cell) {
        return cell is CellAlive or CellDead;
    }
}
