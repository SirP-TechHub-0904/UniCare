﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniCare.Data;
using UniCare.Data.Model;

namespace UniCare.Areas.Staff.Pages.Dashboard
{
    public class MsgDetailsModel : PageModel
    {
        private readonly UniCare.Data.ApplicationDbContext _context;

        public MsgDetailsModel(UniCare.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Message Message { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Messages == null)
            {
                return NotFound();
            }

            var message = await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);
            if (message == null)
            {
                return NotFound();
            }
            else
            {
                message.Read = true;
                _context.Attach(message).State = EntityState.Modified;

                await _context.SaveChangesAsync();
                Message = message;
            }
            return Page();
        }
    }
}
