using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniCare.Data.Model;
using UniCare.Data;
using Microsoft.EntityFrameworkCore;

namespace UniCare.Areas.Admin.Pages.TimeSheetPage
{
         public class AllSheetModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;
        private readonly UserManager<Profile> _userManager;

        public AllSheetModel(UniCare.Data.ApplicationDbContext context, UserManager<Profile> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public List<UserTimeSheet> UserList { get; set; }
        public string MonthYearTitle { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Year { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Month { get; set; }

        public async Task<IActionResult> OnGetAsync(int year, int month)
        {
            Year = year;
            Month = month;

            var appUsers = await _userManager.Users.Where(x => x.Email != "admin@unicare.co").ToListAsync();
            UserList = await _context.UserTimeSheets
                .Include(x => x.TimeSheet)
                .Include(x=>x.User)
                .Where(x => x.TimeSheet.Date.Year == year && x.TimeSheet.Date.Month == month)
.ToListAsync();

           
            if (year > 0)
            {
                MonthYearTitle = new DateTime(year, month, 1).ToString("MMMM yyyy");

            }
            return Page();
        }

    }

}
