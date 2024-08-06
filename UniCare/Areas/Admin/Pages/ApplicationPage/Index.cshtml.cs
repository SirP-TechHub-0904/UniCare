using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniCare.Data;
using UniCare.Data.Model;
//using Microsoft.AspNetCore.Authorization;

namespace UniCare.Areas.Admin.Pages.ApplicationPage
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]

    public class IndexModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;

        public IndexModel(UniCare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Application> Application { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Applications != null)
            {
                Application = await _context.Applications
                .Include(a => a.User).ToListAsync();
            }
        }
    }
}
