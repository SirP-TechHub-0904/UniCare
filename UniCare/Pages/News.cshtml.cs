using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniCare.Data;
using UniCare.Data.Model;

namespace UniCare.Pages
{
    public class NewsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public NewsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<NewsBlog> NewsBlog { get; set; } = default!;

        public async Task OnGetAsync()
        {

            NewsBlog = await _context.NewsBlogs.ToListAsync();

        }
    }
}
