using CourseWork.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Vehicle> Vehicles => Set<Vehicle>();
        public DbSet<VehicleType> VehicleTypes => Set<VehicleType>();
        public DbSet<RentalPoint> RentalPoints => Set<RentalPoint>();
        public DbSet<Rental> Rentals => Set<Rental>();
        public DbSet<GeoZone> GeoZones => Set<GeoZone>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Rental>()
                .HasOne(r => r.StartRentalPoint)
                .WithMany(rp => rp.RentalsStartedHere)
                .HasForeignKey(r => r.StartRentalPointId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Rental>()
                .HasOne(r => r.EndRentalPoint)
                .WithMany(rp => rp.RentalsEndedHere)
                .HasForeignKey(r => r.EndRentalPointId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
