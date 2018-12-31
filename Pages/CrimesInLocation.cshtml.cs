using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjCRS.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjCRS.Pages
{
    public class CrimesInLocationModel : PageModel
    {
        private AppDbContext _context;
        public CrimesInLocationModel(AppDbContext context) {
            _context = context;
        }
        public CrimeLocation CrimeLocations { get; set; }

        public IActionResult OnGet(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            CrimeLocations = _context.CrimeLocation
                                     .Include(cri => cri.CriminalActivities)
                                     .ThenInclude(cri => cri.Criminal)
                                     .Include(cri => cri.CriminalActivities)
                                     .ThenInclude(cri => cri.CriminalCode)
                                     .FirstOrDefault(cri => cri.Id == Id);

            
            if (CrimeLocations == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}