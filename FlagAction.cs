class FlagAction : IPlayerAction
{
    public void Execute(GameBoard board, Position position)
    {
        board.ToggleFlag(position);
    }
}