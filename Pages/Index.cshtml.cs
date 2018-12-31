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
    public class IndexModel : PageModel
    {
        private AppDbContext _context;
        public IndexModel(AppDbContext context) 
        {
            _context = context;
        }

        public void OnGet()
        {
        TotalCrimes = _context.CriminalActivity
                                .Count();
        NumberofCriminalsMale = _context.Criminal
                                .Where (x => x.Gender == "Male" )
                                .Count();
        NumberofCriminalsFemale = _context.Criminal
                                .Where (x => x.Gender == "Female")
                                .Count();                              
        NumberofCriminalswhoareEmployed = _context.Criminal
                                .Where (x => x.Employed == true )
                                .Count();
        NumberofCriminalswhoareUnemployed = _context.Criminal
                                .Where (x => x.Employed == false )
                                .Count();                                                              
                           
        }
       
        public int TotalCrimes { get; set; }
        public int NumberofCriminalsMale { get; set; }
        public int NumberofCriminalsFemale { get; set;}
        public int NumberofCriminalswhoareEmployed { get; set; }
        public int NumberofCriminalswhoareUnemployed { get; set; }
    }
}

