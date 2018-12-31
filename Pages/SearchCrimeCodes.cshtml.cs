using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjCRS.Models; 
using System.ComponentModel.DataAnnotations;

namespace ProjCRS.Pages
{
    public class SearchCrimeCodesModel : PageModel
    {

        public SearchCrimeCodesModel(AppDbContext context) {
            _context = context;
        }


        private AppDbContext _context;
        public void OnGet()
        {
           SearchCompleted = false;
        }
        [BindProperty]
        [Required]
    
        [StringLength(3, MinimumLength = 3, ErrorMessage = "3 digits exactly")]
        public string Search { get; set; }
        
       
        public bool SearchCompleted { get; set; }
        public ICollection<CriminalCode> SearchResults { get; set; }

          public void OnPost() {
           
            if (string.IsNullOrWhiteSpace(Search)) {
              
                return;
            }


            SearchResults = _context.CriminalCode
                                    
                                   
                               
                                    .Where(x => x.Description.ToLower().Contains(Search.ToLower()))
                                    .ToList();
            SearchCompleted = true;
        }


    }
}