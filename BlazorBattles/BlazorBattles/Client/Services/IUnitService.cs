using BlazorBattles.Shared;

namespace BlazorBattles.Client.Services
{
    public interface IUnitService
    {
        IList<Unit> Units { get; }
        IList<UserUnit> UserUnits { get; set; }
        void AddUnit(int unitId);
    }
}
