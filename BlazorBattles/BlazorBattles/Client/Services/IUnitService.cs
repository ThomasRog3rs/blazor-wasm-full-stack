using BlazorBattles.Shared;

namespace BlazorBattles.Client.Services
{
    public interface IUnitService
    {
        IList<Unit> Units { get; set; }
        IList<UserUnit> UserUnits { get; set; }
        Task LoadUnitsAsync();
        void AddUnit(int unitId);
    }
}
