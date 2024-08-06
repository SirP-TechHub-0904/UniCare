using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniCare.Data;
using UniCare.Data.Model;

namespace UniCare.Areas.Admin.Pages.HealthCareQualificationPage
{
    public class CreateModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;

        public CreateModel(UniCare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ApplicationId"] = new SelectList(_context.Applications, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public HealthQualification HealthQualification { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.HealthQualifications == null || HealthQualification == null)
            {
                return Page();
            }

            _context.HealthQualifications.Add(HealthQualification);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
