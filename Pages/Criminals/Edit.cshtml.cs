using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjCRS.Models;

namespace ProjCRS.Pages.Criminals
{
    public class EditModel : PageModel
    {
        private readonly ProjCRS.Models.AppDbContext _context;

        public EditModel(ProjCRS.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Criminal Criminal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Criminal = await _context.Criminal.FirstOrDefaultAsync(m => m.Id == id);

            if (Criminal == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Criminal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CriminalExists(Criminal.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CriminalExists(int id)
        {
            return _context.Criminal.Any(e => e.Id == id);
        }
    }
}
