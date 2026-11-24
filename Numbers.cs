class Numbers : ITile
{
     public bool IsRevealed { get; set; }

    public int BombCount { get; set; }
     public Numbers(int bombCount)
    {
        BombCount = bombCount;
    }

    public void Reveal()
    {
        IsRevealed = true;
        Console.WriteLine(BombCount);
    }

    public void Print()
    {
        if (!IsRevealed)
        {
            Console.Write ("◼ ");
        }

        else
        {
            Console.Write(BombCount + " ");
        }
    }
}