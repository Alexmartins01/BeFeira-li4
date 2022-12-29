using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Feira
{
    public class DetailsModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraFeiraContext _context;

        public DetailsModel(BeFeira.Data.BeFeiraFeiraContext context)
        {
            _context = context;
        }

      public BeFeira.Models.Feira Feira { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Feira == null)
            {
                return NotFound();
            }

            var feira = await _context.Feira.FirstOrDefaultAsync(m => m.FeiraId == id);
            if (feira == null)
            {
                return NotFound();
            }
            else 
            {
                Feira = feira;
            }
            return Page();
        }
    }
}
