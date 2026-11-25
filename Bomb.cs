class Bomb : ITile
{
    private bool IsRevealed;
    private bool IsFlagged;
    
    public void Reveal(IGameMode gameMode)
    {
        IsRevealed = true;
        gameMode.BombDamage(this);
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
            Console.Write("☠︎︎ ");
        }
        
    }

   public void PlaceFlag()
    {
        IsFlagged = true;
    }

}