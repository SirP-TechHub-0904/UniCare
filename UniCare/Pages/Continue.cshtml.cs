using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniCare.Data.Model;
using UniCare.Data;
using Microsoft.EntityFrameworkCore;

namespace UniCare.Pages
{
    public class ContinueModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ContinueModel(ApplicationDbContext context)
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
