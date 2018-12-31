using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjCRS.Models;

namespace ProjCRS.Pages.CriminalCodes
{
    public class IndexModel : PageModel
    {
        private readonly ProjCRS.Models.AppDbContext _context;

        public IndexModel(ProjCRS.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<CriminalCode> CriminalCode { get;set; }

        public async Task OnGetAsync()
        {
            CriminalCode = await _context.CriminalCode.ToListAsync();
        }
    }
}
