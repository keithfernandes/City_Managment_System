using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjCRS.Models;

namespace ProjCRS.Pages.CriminalCodes
{
    public class EditModel : PageModel
    {
        private readonly ProjCRS.Models.AppDbContext _context;

        public EditModel(ProjCRS.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CriminalCode CriminalCode { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CriminalCode = await _context.CriminalCode.FirstOrDefaultAsync(m => m.Id == id);

            if (CriminalCode == null)
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

            _context.Attach(CriminalCode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CriminalCodeExists(CriminalCode.Id))
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

        private bool CriminalCodeExists(int id)
        {
            return _context.CriminalCode.Any(e => e.Id == id);
        }
    }
}
