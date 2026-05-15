using CourseWork.Data;
using CourseWork.Models;
using CourseWork.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Pages
{
    public class ActiveRentalsModel : PageModel
    {
        private readonly AppDbContext _db;
        private readonly RentalService _rentalService;

        public ActiveRentalsModel(AppDbContext db, RentalService rentalService)
        {
            _db = db;
            _rentalService = rentalService;
        }

        public List<Rental> Rentals { get; set; } = new();

        [TempData]
        public string Message { get; set; }

        public async Task OnGetAsync()
        {
            Rentals = await _db.Rentals
                .Include(r => r.Client)
                .Include(r => r.Vehicle)
                    .ThenInclude(v => v.VehicleType)
                .Where(r => r.EndTime == null)
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostEndRentalAsync(int rentalId, double endLatitude, double endLongitude)
        {
            var result = await _rentalService.EndRentalAsync(rentalId, endLatitude, endLongitude);
            Message = result.Success ? "Успіх: " + result.Message : "Помилка: " + result.Message;

            return RedirectToPage();
        }
    }
}
