class Bomb : ITile
{
     public bool IsRevealed { get; set; }

    public void Reveal()
    {
        IsRevealed = true;
        Console.WriteLine("BOOM! Du träffade en bomb!");
    }

    public void Print()
    {
        if (!IsRevealed)
        {
            Console.Write ("█ ");
        }

        else
        {
            Console.Write("☠︎︎ ");
        }
        
    }
}