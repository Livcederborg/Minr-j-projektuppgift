class SurvivalMode : IGameMode
{
   
    private int lives = 3;
    private bool gameOver;

    public void BombDamage(ITile tile)
    {
        lives--;

        Console.WriteLine("Du träffade en bomb!");
        Console.WriteLine("Liv kvar: " + lives);

        if (lives <= 0)
        {
            gameOver = true;
            Console.WriteLine("Du har förlorat!");
        }
    }

    public bool IsGameOver()
    {
        return gameOver;
    }
}
