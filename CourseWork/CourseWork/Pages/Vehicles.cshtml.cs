using CourseWork.Data;
using CourseWork.Models;
using CourseWork.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Pages
{
    public class VehiclesModel : PageModel
    {
        private readonly AppDbContext _db;
        private readonly RentalService _rentalService;

        public VehiclesModel(AppDbContext db, RentalService rentalService)
        {
            _db = db;
            _rentalService = rentalService;
        }

        public List<Vehicle> AvailableVehicles { get; set; } = new();

        [TempData]
        public string Message { get; set; }

        public async Task OnGetAsync()
        {
            AvailableVehicles = await _db.Vehicles
                .Include(v => v.VehicleType)
                .Include(v => v.RentalPoint)
                .Where(v => v.IsAvailable)
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostStartRentalAsync(int clientId, int vehicleId)
        {
            var result = await _rentalService.StartRentalAsync(clientId, vehicleId);
            Message = result.Success ? "Успіх: " + result.Message : "Помилка: " + result.Message;

            return RedirectToPage();
        }
    }
}
