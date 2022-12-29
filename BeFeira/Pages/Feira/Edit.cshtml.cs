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

namespace BeFeira.Pages.Feira
{
    public class EditModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraFeiraContext _context;

        public EditModel(BeFeira.Data.BeFeiraFeiraContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BeFeira.Models.Feira Feira { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Feira == null)
            {
                return NotFound();
            }

            var feira =  await _context.Feira.FirstOrDefaultAsync(m => m.FeiraId == id);
            if (feira == null)
            {
                return NotFound();
            }
            Feira = feira;
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

            _context.Attach(Feira).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeiraExists(Feira.FeiraId))
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

        private bool FeiraExists(int id)
        {
          return (_context.Feira?.Any(e => e.FeiraId == id)).GetValueOrDefault();
        }
    }
}
