using BlazorBattles.Shared;
using Blazored.Toast.Services;
using System.Net.Http.Json;

namespace BlazorBattles.Client.Services
{
    public class UnitService : IUnitService
    {
        private readonly IToastService _toastService;
        private readonly HttpClient _httpClient;
        public UnitService(IToastService toastService, HttpClient httpClient)
        {
            _toastService = toastService;
            _httpClient = httpClient;
        }
        public IList<Unit> Units { get; set; } = new List<Unit>();
        public IList<UserUnit> UserUnits { get; set; } = new List<UserUnit>();

        public async Task LoadUnitsAsync()
        {
            if(Units.Count <= 0)
            {
                Units = await _httpClient.GetFromJsonAsync<IList<Unit>>("/api/unit");
            }
        }

        public void AddUnit(int unitId)
        {
            var unit = Units.First(unit => unit.Id == unitId);
            UserUnits.Add(new UserUnit { UnitId = unitId, HitPoints = unit.HitPoints});
            _toastService.ShowSuccess($"{unit.Title} has been added to your army", "Unit created!");
        }

        public override bool Equals(object? obj)
        {
            return obj is UnitService service &&
                   EqualityComparer<IList<Unit>>.Default.Equals(Units, service.Units) &&
                   EqualityComparer<IList<UserUnit>>.Default.Equals(UserUnits, service.UserUnits);
        }
    }
}
