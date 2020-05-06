﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp_Potlog_Mihaela_Rp.Data;
using Asp_Potlog_Mihaela_Rp.Models;

namespace Asp_Potlog_Mihaela_Rp.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly Asp_Potlog_Mihaela_Rp.Data.Asp_Potlog_Mihaela_RpContext _context;

        public DeleteModel(Asp_Potlog_Mihaela_Rp.Data.Asp_Potlog_Mihaela_RpContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
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

            Movie = await _context.Movie.FindAsync(id);

            if (Movie != null)
            {
                _context.Movie.Remove(Movie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
