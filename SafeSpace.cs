class SafeSpace : ITile
{
    private bool IsRevealed;

    private bool IsFlagged;

    public void Reveal(IGameMode gameMode)
    {
        IsRevealed = true;
        Console.WriteLine("Tom ruta!");

        
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
            Console.Write("𖹭 ");
        }
        
    }

    public void PlaceFlag()
    {
        IsFlagged = true;
    }

    public bool ShouldReveal ()
    {
            return !IsRevealed && !IsFlagged;

    }
}
