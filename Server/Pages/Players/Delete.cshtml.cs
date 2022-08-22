﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestASP.Data;
using TestASP.Models;

namespace TestASP.Pages.Players
{
    public class DeleteModel : PageModel
    {
        private readonly TestASP.Data.TestASPContext _context;

        public DeleteModel(TestASP.Data.TestASPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblPlayers TblPlayers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblPlayers = await _context.TblPlayers.FirstOrDefaultAsync(m => m.Id == id);

            if (TblPlayers == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblPlayers = await _context.TblPlayers.FindAsync(id);

            if (TblPlayers != null)
            {
                _context.TblPlayers.Remove(TblPlayers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
