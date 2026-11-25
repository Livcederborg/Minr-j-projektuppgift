class KeyboardInput
{
    public void HandleInput(ConsoleKey key, Position position, GameBoard gameBoard)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
            case ConsoleKey.DownArrow:
            case ConsoleKey.LeftArrow:
            case ConsoleKey.RightArrow:
                position.Move(key);
                break;

            case ConsoleKey.Spacebar:
                gameBoard.PerformAction(
                    position, new RevealAction());
                break;

            case ConsoleKey.F:
                gameBoard.PerformAction(
                    position, new FlagAction());
                break;
        }
    }
}
