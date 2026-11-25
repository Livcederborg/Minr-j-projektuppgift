class ClassicMode : IGameMode
{
    private bool gameOver;

    public void BombDamage(ITile tile)
    {
        gameOver = true;
        Console.WriteLine("BOOM du förlorade!");
    }

    public bool IsGameOver()
    {
        return gameOver;
    }
} 