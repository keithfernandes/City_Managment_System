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
    public class CriminalProfileModel : PageModel
    {
        private AppDbContext _context;

        public CriminalProfileModel(AppDbContext context) {
            _context = context;
        
        }
         public Criminal Criminal{ get; set; }

        public IActionResult OnGet(int? id)
        {
           if (id == null)
          {
        return NotFound();
           }
    
           
               Criminal= _context.Criminal
                             
                                .Include(est => est.CriminalActivities)
                                .ThenInclude(est => est.Location)
                                .Include(est => est.CriminalActivities)
                                .ThenInclude(est => est.CriminalCode)
                                
                                .FirstOrDefault(est => est.Id == id);

            if (Criminal == null) {
               return NotFound();
             }
              return Page();  
        }
    }
}