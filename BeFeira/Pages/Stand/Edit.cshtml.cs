using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Stand
{
    public class EditModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraStandContext _context;

        public EditModel(BeFeira.Data.BeFeiraStandContext context)
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

            var stand =  await _context.Stand.FirstOrDefaultAsync(m => m.StandId == id);
            if (stand == null)
            {
                return NotFound();
            }
            Stand = stand;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Stand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StandExists(Stand.StandId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StandExists(int id)
        {
          return (_context.Stand?.Any(e => e.StandId == id)).GetValueOrDefault();
        }
    }
}
