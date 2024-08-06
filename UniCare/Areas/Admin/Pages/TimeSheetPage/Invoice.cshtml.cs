using UniCare.Data.Model;
using UniCare.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace UniCare.Areas.Admin.Pages.TimeSheetPage
{
    public class InvoiceModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;
        private readonly UserManager<Profile> _userManager;

        public InvoiceModel(UniCare.Data.ApplicationDbContext context, UserManager<Profile> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public Invoice Invoice { get; set; }
       
        public string Fullname { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {


            if (id == null || _context.Invoices == null)
            {
                return NotFound();
            }

            Invoice = await _context.Invoices
                .Include(x=>x.User)
               .FirstOrDefaultAsync(uts => uts.Id == id);

          
            Fullname = Invoice.User.FirstName +" " + Invoice.User.Surname;
           

            return Page();
        }
    }
}

