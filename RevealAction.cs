class RevealAction : IPlayerAction
{
          public void Execute(ITile tile, IGameMode gameMode)
    {
        tile.Reveal(gameMode);
    }
    }
