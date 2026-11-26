class RevealAction : IPlayerAction
{
    public void Execute(ITile tile, IGameMode gameMode, Position position)
    {
        if (tile.ShouldReveal())
        {
            tile.Reveal(gameMode);
            RevealNeighbors(position.Row, position.Col, this);
        }
        else {
        tile.Reveal(gameMode);
        }
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

        ITile tile = Tile[row, col];

        if (tile.ShouldReveal())
        {
            a.Execute(tile, gameMode);
            RevealNeighbors(row, col, a);


        }

        else
            a.Execute(tile, gameMode);

    }

    
}
