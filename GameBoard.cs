class GameBoard
{
    private ITile[,] Tiles;
    private IGameMode gameMode;

    private int Width;
    private int Height;

    private Position position;

    public GameBoard(char[,] board, Position position, IGameMode gameMode)
    {
        Height = board.GetLength(0);
        Width = board.GetLength(1);
        this.position = position;

        TileFactory factory = new TileFactory(board);

        Tiles = factory.CreateTiles();
        this.gameMode = gameMode;

    }
    public void PrintBoard(Position position)
    {
        for (int row = 0; row < Height; row++)
        {
            for (int col = 0; col < Width; col++)
            {

                if (row == position.Row && col == position.Col)
                {
                    Console.Write("☆ ");
                }

                else
                {
                    Tiles[row, col].Print();
                }





            }

            Console.WriteLine();
        }
    }
    public void PerformAction(Position position, IPlayerAction action)
    {
        ITile tile = Tiles[position.Row, position.Col];

            action.Execute(tile, gameMode, position);

    }

    public void RevealNeighbors(int row, int col, IPlayerAction a)
    {
        for (int r = -1; r <= 1; r++)
        {
            for (int c = -1; c <= 1; c++)
            {
                if (r == 0 && c == 0)
                    continue;

                RevealTile(row + r, col + c, a);

            }
        }
    }
    public void RevealTile(int row, int col, IPlayerAction a)
    {
        if (row < 0 || row >= Height ||
            col < 0 || col >= Width)
            return;

        ITile tile = Tiles[row, col];

        if (tile.ShouldReveal())
        {
            a.Execute(tile, gameMode);
            RevealNeighbors(row, col, a);


        }

        else
            a.Execute(tile, gameMode);

    }

}

