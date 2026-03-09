using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Weather> Weathers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Weather>().HasData(
                new Weather { Id = 1, Date = new DateTime(2026, 03, 04, 0, 0, 0, DateTimeKind.Utc), TemperatureC = 15, Summary = "Mild" },
                new Weather { Id = 2, Date = new DateTime(2026, 03, 05, 0, 0, 0, DateTimeKind.Utc), TemperatureC = 18, Summary = "Mild" },
                new Weather { Id = 3, Date = new DateTime(2026, 03, 06, 0, 0, 0, DateTimeKind.Utc), TemperatureC = 25, Summary = "Warm" },
                new Weather { Id = 4, Date = new DateTime(2026, 03, 07, 0, 0, 0, DateTimeKind.Utc), TemperatureC = 5, Summary = "Cool" }
                );
        }
    }
}
