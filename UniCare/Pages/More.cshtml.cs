using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniCare.Data;
using UniCare.Data.Model;

namespace UniCare.Pages
{
    public class MoreModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public MoreModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public NewsBlog NewsBlog { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
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
