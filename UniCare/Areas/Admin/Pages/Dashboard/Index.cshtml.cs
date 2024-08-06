using UniCare.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace UniCare.Areas.Admin.Pages.Dashboard
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]

    public class IndexModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;

        public IndexModel(UniCare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public int Appointment { get; set; } 
        public int Application { get; set; }
        public int User { get; set; }

        public async Task OnGetAsync()
        {
             
                Appointment = await _context.Appointments.CountAsync();
            Application = await _context.Applications.CountAsync();
            User = await _context.Users.Where(x => x.Email != "admin@unicare.co").CountAsync();
             
        }
    }
}
