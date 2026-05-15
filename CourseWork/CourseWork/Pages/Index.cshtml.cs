using CourseWork.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace CourseWork.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public string MapDataJson { get; set; } = "[]";
        public string RentalPointsJson { get; set; } = "[]";

        public async Task OnGetAsync()
        {
            var vehicles = await _db.Vehicles
                .Include(v => v.VehicleType)
                .Where(v => v.IsAvailable && v.CurrentLocation != null)
                .ToListAsync();

            var mapPoints = vehicles.Select(v => new
            {
                id = v.Id,
                name = v.VehicleType.Name,
                category = v.VehicleType.Category,
                battery = v.BatteryLevel,
                lat = v.CurrentLocation.Y, // Y is Latitude
                lng = v.CurrentLocation.X  // X is Longitude
            });

            var rentalPoints = await _db.RentalPoints
                .Where(rp => rp.Location != null)
                .ToListAsync();

            var rpPoints = rentalPoints.Select(rp => new
            {
                id = rp.Id,
                name = rp.Name,
                address = rp.Address,
                lat = rp.Location.Y,
                lng = rp.Location.X
            });

            MapDataJson = JsonSerializer.Serialize(mapPoints);
            RentalPointsJson = JsonSerializer.Serialize(rpPoints);
        }
    }
}
