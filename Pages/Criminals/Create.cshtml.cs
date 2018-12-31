using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjCRS.Models;


namespace ProjCRS.Pages.Criminals
{
    public class CreateModel : PageModel
    {
        private readonly ProjCRS.Models.AppDbContext _context;

        public CreateModel(ProjCRS.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
          
          
          
            return Page();
        }

        [BindProperty]
        public Criminal Criminal { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Criminal.Add(Criminal);
            await _context.SaveChangesAsync();

            return Redirect(url: "https://localhost:5001/CrimeLocations/Create");
        }
    }
}