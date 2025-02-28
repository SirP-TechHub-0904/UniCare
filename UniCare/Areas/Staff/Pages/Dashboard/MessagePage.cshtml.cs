using UniCare.Data.Model;
using UniCare.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace UniCare.Areas.Staff.Pages.Dashboard
{
    [Authorize]
    public class MessagePageModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;
        private readonly UserManager<Profile> _userManager;

        public MessagePageModel(UniCare.Data.ApplicationDbContext context, UserManager<Profile> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public List<Message> Message { get; set; }

        public async Task OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            Message = await _context.Messages
                .Include(x => x.User)
                .Where(x => x.UserId == user.Id || x.All == true).OrderByDescending(x=>x.Date).ToListAsync();

        }
    }
}
