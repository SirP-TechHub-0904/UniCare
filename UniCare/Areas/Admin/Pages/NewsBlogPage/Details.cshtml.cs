using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniCare.Data;
using UniCare.Data.Model;

namespace UniCare.Areas.Admin.Pages.NewsBlogPage
{
    public class DetailsModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;

        public DetailsModel(UniCare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public NewsBlog NewsBlog { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.NewsBlogs == null)
            {
                return NotFound();
            }

            var newsblog = await _context.NewsBlogs.FirstOrDefaultAsync(m => m.Id == id);
            if (newsblog == null)
            {
                return NotFound();
            }
            else 
            {
                NewsBlog = newsblog;
            }
            return Page();
        }
    }
}
