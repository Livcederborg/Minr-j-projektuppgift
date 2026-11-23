using Microsoft.Win32.SafeHandles;

class TileFactory
{
    private char [,] board;
    public TileFactory (char [,] board)
    {
        if (board == null)
        throw new ArgumentNullException (nameof(board));

        this.board = board;


    }

    public ITile[,] CreateTiles ()

    {   int rows = board.GetLength(0);
        int cols = board.GetLength(1);
        ITile[,] tiles = new ITile[rows,cols];
       for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                char c = board[row, col];

                if (c == 'B')
                    tiles[row, col] = new Bomb();

                else if (c == 'S')
                    tiles[row, col] = new SafeSpace();

                else
                    tiles[row, col] = new Numbers(c - '0');
            }
        }

        return tiles;
    }
}