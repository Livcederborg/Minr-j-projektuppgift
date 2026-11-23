class GameBoard 
{
    public ITile[,] Tiles { get; set; }

    public int Width { get; set; }
    public int Height { get; set; }

    public GameBoard(int width, int height)
    {
        Width = width;
        Height = height;

        Tiles = new ITile[width, height];
    }
    
}