class FlagAction : IPlayerAction
{
    public void Execute(ITile tile, IGameMode gameMode)
    {
        tile.PlaceFlag();
    }
}


//känns inte som det här ggränssnittet behövs, man vi måste ha fler gränssnitt i vårt spel :S you win some you loose some:S