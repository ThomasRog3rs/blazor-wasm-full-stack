using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorBattles.Shared;

namespace BlazorBattles.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        public IList<Unit> Units => new List<Unit> {
            new Unit { Id = 1, Title = "Knight", Attack = 10, Defence = 10, Cost = 100 },
            new Unit { Id = 2, Title = "Archer", Attack = 15, Defence = 5, Cost = 150 },
            new Unit { Id = 3, Title = "Mage", Attack = 20, Defence = 1, Cost = 200 }
        };

        [HttpGet]
        public IActionResult GetUnits()
        {
            return Ok(Units);
        }
    }
}
