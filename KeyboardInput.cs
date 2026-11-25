class KeyboardInput
{
    public IPlayerAction ReadAction()
    {
        ConsoleKey key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.Spacebar)
            return new RevealAction();

        if (key == ConsoleKey.F)
            return new FlagAction();

        return null;
    }
}