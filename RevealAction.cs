class RevealAction : IPlayerAction
{
    public void Execute(GameBoard board, Position position)
    {
        board.RevealTile(position);
    }
}