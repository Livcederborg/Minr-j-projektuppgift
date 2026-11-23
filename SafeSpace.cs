class SafeSpace : ITile
{
    public bool IsRevealed { get; set; }

    public void Reveal()
    {
        IsRevealed = true;
        Console.WriteLine("Tom ruta!");
    }

    public void Print()
    {
        
    }
}
