﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniCare.Data;
using UniCare.Data.Model;

namespace UniCare.Areas.Admin.Pages.WebMails
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
            return Page();
        }

        [BindProperty]
        public MailSystem MailSystem { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MailSystems.Add(MailSystem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
