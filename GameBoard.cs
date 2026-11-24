class GameBoard 
{
    public ITile[,] Tiles { get; private set; }

    public int Width { get; private set; }
    public int Height { get; private set; }

    private Position position;

    public GameBoard(char[,] board, Position position)
    {
        Height = board.GetLength(0);
        Width = board.GetLength(1);
        this.position = position;

        TileFactory factory = new TileFactory(board);

        Tiles = factory.CreateTiles();
        
    }
    public void PrintBoard(Position position)
    {
        for (int row = 0; row < Height; row++)
        {
            for (int col = 0; col < Width; col++)
            {
                
                if (row == position.Row() && col == position.Col())
                {
                    Console.Write ("☆ ");
                }

                else
                {
                    Tiles[row, col].Print();
                }
                
                
                
                
                
            }

            Console.WriteLine();
        }
    }
    
    
}

