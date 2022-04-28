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
        for (int i = 0; i < Rows; i++)
            for (int j = 0; j < Columns; j++) 
            {
                var numberOfNeighbours = GetNumberOfAliveNeighbours(i,j);


                // If 0 or 1 neighbours, die
                switch (numberOfNeighbours) {
                    case 0:
                    case 1:
                        State[i,j] = 0;
                        break;
                    default: throw new Exception();
                }
                
                // If 2 neighbours stay as is

                // If 3 neighbours, procreate or stay alive

                // If 4 or greater neighbours, die

            }
        throw new NotImplementedException();
    }

    private int GetNumberOfAliveNeighbours(int row, int column) {
        int numberOfNeighbours = 0;
        int[] rowBoundaries = new int[]{-1,0,1};
        int[] columnBoundaries = new int[]{-1,0,1};

        for (int i = 0; i < rowBoundaries.Length; i++)
            for (int j = 0; j < columnBoundaries.Length; j++) {
                var rowCheckedCoord = row + rowBoundaries[i];
                var columnCheckedCoord = column + columnBoundaries[j];

                if (rowCheckedCoord < 0 || columnCheckedCoord < 0 || (rowCheckedCoord == row && columnCheckedCoord == column))
                    continue;

                numberOfNeighbours += State[rowCheckedCoord, columnCheckedCoord];
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
