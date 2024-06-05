using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniCare.Data.Model;
using UniCare.Data;
using Microsoft.EntityFrameworkCore;

namespace UniCare.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<NewsBlog> NewsBlog { get; set; } = default!;
        public IList<Testimony> Testimony { get; set; } = default!;

        public async Task OnGetAsync()
        {

            NewsBlog = await _context.NewsBlogs.OrderByDescending(x=>x.Date).Take(3).ToListAsync();
            Testimony = await _context.Testimonies.OrderByDescending(x => x.SortOrder).Take(4).ToListAsync();

        }
    }
}
