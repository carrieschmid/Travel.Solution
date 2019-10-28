using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options)
            : base(options)
        {
        }

        public DbSet<Destination> Destinations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.Entity<Destination>()
                .HasData(
                new Destination { DestinationId = 2, City = "Oakland", Country = "USA", Review = "Sunny, mild, rough", Rating = 2 },
                new Destination { DestinationId = 3, City = "Sayulita", Country = "Mexico", Review = "Crowded and touristy, but still beautiful and warm.", Rating = 4 },
                new Destination { DestinationId = 4, City = "Santiago", Country = "Chile", Review = "Busy, a little smoggy, gorgeous mountains", Rating = 3 },
                new Destination { DestinationId = 5, City = "Lagos", Country = "Nigeria", Review = "Vast, expansive", Rating = 5 },
                new Destination { DestinationId = 6, City = "Cairo", Country = "Eqypt", Review = "So many incredible places to visit", Rating = 5 }
                );
            }
    }
}