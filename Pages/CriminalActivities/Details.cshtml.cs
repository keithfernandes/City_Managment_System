using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjCRS.Models;

namespace ProjCRS.Pages.CriminalActivities
{
    public class DetailsModel : PageModel
    {
        private readonly ProjCRS.Models.AppDbContext _context;

        public DetailsModel(ProjCRS.Models.AppDbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
