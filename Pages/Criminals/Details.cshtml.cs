using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjCRS.Models;

namespace ProjCRS.Pages.Criminals
{
    public class DetailsModel : PageModel
    {
        private readonly ProjCRS.Models.AppDbContext _context;

        public DetailsModel(ProjCRS.Models.AppDbContext context)
        {
            _context = context;
        }

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
    }
}
