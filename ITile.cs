public interface ITile 
{
    void Reveal(IGameMode gamemode);
    void Print();

    bool ShouldReveal();

    void PlaceFlag();
}
