﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniCare.Data;
using UniCare.Data.Model;

namespace UniCare.Areas.Admin.Pages.WebMails
{
    public class DetailsModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;

        public DetailsModel(UniCare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public MailSystem MailSystem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MailSystem = await _context.MailSystems.FirstOrDefaultAsync(m => m.Id == id);

            if (MailSystem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
