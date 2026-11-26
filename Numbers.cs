class Numbers : ITile
{
     private bool IsRevealed;

     private bool IsFlagged;

    private int BombCount;
     public Numbers(int bombCount)
    {
        BombCount = bombCount;
    }

    public void Reveal(IGameMode gameMode)
    {
        IsRevealed = true;
        Console.WriteLine(BombCount);
    }

    public void Print()
    {
        if (IsFlagged)
        {
            Console.Write ("⚐ "); 
        }
        else if (!IsRevealed)
        {
            Console.Write ("◼ ");
        }

        else
        {
            Console.Write(BombCount + " ");
        }
    }

    public void PlaceFlag()
    {
        IsFlagged = true;
    }

    public bool ShouldReveal ()
    {
        return false;
    }
}