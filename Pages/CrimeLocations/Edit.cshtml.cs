using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjCRS.Models;

namespace ProjCRS.Pages.CrimeLocations
{
    public class EditModel : PageModel
    {
        private readonly ProjCRS.Models.AppDbContext _context;

        public EditModel(ProjCRS.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CrimeLocation CrimeLocation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CrimeLocation = await _context.CrimeLocation.FirstOrDefaultAsync(m => m.Id == id);

            if (CrimeLocation == null)
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

            _context.Attach(CrimeLocation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CrimeLocationExists(CrimeLocation.Id))
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

        private bool CrimeLocationExists(int id)
        {
            return _context.CrimeLocation.Any(e => e.Id == id);
        }
    }
}
