using CourseWork.Data;
using CourseWork.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Pages
{
    public class ClientsModel : PageModel
    {
        private readonly AppDbContext _db;

        public ClientsModel(AppDbContext db)
        {
            _db = db;
        }

        public List<Client> Clients { get; set; } = new();

        public async Task OnGetAsync()
        {
            Clients = await _db.Clients.ToListAsync();
        }
    }
}
