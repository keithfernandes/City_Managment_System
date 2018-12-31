using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjCRS.Models;

namespace ProjCRS.Pages.CriminalCodes
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
        public CriminalCode CriminalCode { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CriminalCode.Add(CriminalCode);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}