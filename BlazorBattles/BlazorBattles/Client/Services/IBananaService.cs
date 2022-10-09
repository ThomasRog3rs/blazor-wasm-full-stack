namespace BlazorBattles.Client.Services
{
    public interface IBananaService
    {
        event Action onChange;
        int Bananas { get; set; }
        void EatBananas(int amount);
        void AddBananas(int amount);
    }
}
