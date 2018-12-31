using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjCRS.Models;

namespace ProjCRS.Pages.CrimeLocations
{
    public class DeleteModel : PageModel
    {
        private readonly ProjCRS.Models.AppDbContext _context;

        public DeleteModel(ProjCRS.Models.AppDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CrimeLocation = await _context.CrimeLocation.FindAsync(id);

            if (CrimeLocation != null)
            {
                _context.CrimeLocation.Remove(CrimeLocation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
