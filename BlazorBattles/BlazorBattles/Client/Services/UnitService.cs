using BlazorBattles.Shared;

namespace BlazorBattles.Client.Services
{
    public class UnitService : IUnitService
    {
        public IList<Unit> Units => new List<Unit> { 
            new Unit { Id = 1, Title = "Knight", Attack = 10, Defence = 10, Cost = 100 },
            new Unit { Id = 2, Title = "Archer", Attack = 15, Defence = 5, Cost = 150 },
            new Unit { Id = 3, Title = "Mage", Attack = 20, Defence = 1, Cost = 200 }
        };
        public IList<UserUnit> UserUnits { get; set; } = new List<UserUnit>();

        public void AddUnit(int unitId)
        {
            var unit = Units.First(unit => unit.Id == unitId);
            UserUnits.Add(new UserUnit { UnitId = unitId, HitPoints = unit.HitPoints});
        }
    }
}
