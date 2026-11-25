public interface IGameMode
{
    bool IsGameOver();
    void BombDamage(ITile tile);
}