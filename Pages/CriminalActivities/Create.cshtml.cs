using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjCRS.Models;

namespace ProjCRS.Pages.CriminalActivities
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
        ViewData["CriminalId"] = new SelectList(_context.Criminal, "Id", "FullName");
         

        ViewData["CriminalCodeId"] = new SelectList(_context.CriminalCode, "Id", "CodeWDescription");
        ViewData["LocationId"] = new SelectList(_context.CrimeLocation, "Id", "FullAddress");
            return Page();
        }

        [BindProperty]
        public CriminalActivity CriminalActivity { get; set; }

        public bool SubmitCompleted { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CriminalActivity.Add(CriminalActivity);
            await _context.SaveChangesAsync();

            SubmitCompleted = true;

            return Page();
             
        }
    }
}