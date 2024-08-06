using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniCare.Data;
using UniCare.Data.Model;

namespace UniCare.Areas.Admin.Pages.ApplicationPage
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]

    public class DetailsModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;

        public DetailsModel(UniCare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Application Application { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Applications == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .Include(x=>x.Qualifications)
                .Include(x=>x.EmploymentHistories)
                .Include(x=>x.ApplicationReferences)
                .Include(x=>x.OccupationalHealthAssessments)
                .Include(x=>x.Vacination)
                .Include(x=>x.HealthQualifications)
                .Include(x=>x.Documents)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (application == null)
            {
                return NotFound();
            }
            else 
            {
                Application = application;
            }
            return Page();
        }
    }
}
