using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniCare.Data;
using UniCare.Data.Model;

namespace UniCare.Areas.Admin.Pages.MessagesPage
{
    public class CreateModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;

        public CreateModel(UniCare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGet()
        {
            ViewData["UserId"] = new SelectList(_context.Users.Where(x => x.Email != "admin@unicare.co"), "Id", "Email");

            return Page();
        }

        [BindProperty]
        public Message Message { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if(Message.UserId == "All")
            {
                Message.All = true;
                Message.UserId = null;
            }
           
          Message.Date = DateTime.UtcNow.AddHours(1);
            _context.Messages.Add(Message);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
