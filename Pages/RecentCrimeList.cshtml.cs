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
    public class RecentCrimeListModel : PageModel
    {
        private AppDbContext _context;
        public RecentCrimeListModel(AppDbContext context) {
            _context = context;
        }
        public List<CriminalActivity> CriminalActivity { get; set; }


         public void OnGet()
        {
            CriminalActivity = _context.CriminalActivity
            .Include(est => est.Location)
            .Include(est => est.CriminalCode)
            .OrderBy(est => est.TimeOfOccurance)
            .Where(est => est.TimeOfOccurance >  DateTime.Today.AddDays(-7))
            .ToList();;
                             
                              

        }
    }
}