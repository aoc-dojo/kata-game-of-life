namespace Life;

public static class BoardExtensions
{
    public static void Print(this Board board)
    {
        var state = board.State;
        for (var i = 0; i < board.Rows; i++)
        {
            for (var j = 0; j < board.Columns; j++)
            {
                Console.Write(state[i, j] == 0 ? " - " : " * ");
            }
            Console.WriteLine();
        }
    }
}
