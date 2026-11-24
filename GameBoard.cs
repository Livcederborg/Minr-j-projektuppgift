class GameBoard 
{
    public ITile[,] Tiles { get; private set; }

    public int Width { get; private set; }
    public int Height { get; private set; }

    public GameBoard(char[,] board)
    {
        Height = board.GetLength(0);
        Width = board.GetLength(1);

        TileFactory factory = new TileFactory(board);

        Tiles = factory.CreateTiles();
        
    }
    public void PrintBoard()
    {
        for (int row = 0; row < Height; row++)
        {
            for (int col = 0; col < Width; col++)
            {
                
                
                Tiles[row, col].Print();
                
                
            }

            Console.WriteLine();
        }
    }
    
    
}

