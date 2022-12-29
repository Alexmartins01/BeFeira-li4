using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Stand
{
    public class DeleteModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraStandContext _context;

        public DeleteModel(BeFeira.Data.BeFeiraStandContext context)
        {
            _context = context;
        }

        [BindProperty]
      public BeFeira.Models.Stand Stand { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Stand == null)
            {
                return NotFound();
            }

            var stand = await _context.Stand.FirstOrDefaultAsync(m => m.StandId == id);

            if (stand == null)
            {
                return NotFound();
            }
            else 
            {
                Stand = stand;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Stand == null)
            {
                return NotFound();
            }
            var stand = await _context.Stand.FindAsync(id);

            if (stand != null)
            {
                Stand = stand;
                _context.Stand.Remove(Stand);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
