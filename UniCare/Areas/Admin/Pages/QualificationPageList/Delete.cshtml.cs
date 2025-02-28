﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniCare.Data;
using UniCare.Data.Model;

namespace UniCare.Areas.Admin.Pages.QualificationPageList
{
    public class DeleteModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;

        public DeleteModel(UniCare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Qualification Qualification { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Qualifications == null)
            {
                return NotFound();
            }

            var qualification = await _context.Qualifications.FirstOrDefaultAsync(m => m.Id == id);

            if (qualification == null)
            {
                return NotFound();
            }
            else 
            {
                Qualification = qualification;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Qualifications == null)
            {
                return NotFound();
            }
            var qualification = await _context.Qualifications.FindAsync(id);

            if (qualification != null)
            {
                Qualification = qualification;
                _context.Qualifications.Remove(Qualification);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
