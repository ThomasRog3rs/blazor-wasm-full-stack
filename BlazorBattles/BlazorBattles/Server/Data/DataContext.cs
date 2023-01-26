using Microsoft.EntityFrameworkCore;
using BlazorBattles.Shared;

namespace BlazorBattles.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        public DbSet<Unit> Units { get; set; }
    }
}
