using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjCRS.Models;

namespace ProjCRS.Pages.CriminalActivities
{
    public class EditModel : PageModel
    {
        private readonly ProjCRS.Models.AppDbContext _context;

        public EditModel(ProjCRS.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CriminalActivity CriminalActivity { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CriminalActivity = await _context.CriminalActivity
                .Include(c => c.Criminal)
                .Include(c => c.CriminalCode)
                .Include(c => c.Location).FirstOrDefaultAsync(m => m.Id == id);

            if (CriminalActivity == null)
            {
                return NotFound();
            }
            ViewData["CriminalId"] = new SelectList(_context.Criminal, "Id", "FullName");
            ViewData["CriminalCodeId"] = new SelectList(_context.CriminalCode, "Id", "CodeWDescription");
            ViewData["LocationId"] = new SelectList(_context.CrimeLocation, "Id", "FullAddress");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CriminalActivity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CriminalActivityExists(CriminalActivity.Id))
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

        private bool CriminalActivityExists(int id)
        {
            return _context.CriminalActivity.Any(e => e.Id == id);
        }
    }
}
