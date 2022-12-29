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

namespace BeFeira.Pages.Vendedor
{
    public class EditModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraVendedorContext _context;

        public EditModel(BeFeira.Data.BeFeiraVendedorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BeFeira.Models.Vendedor Vendedor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Vendedor == null)
            {
                return NotFound();
            }

            var vendedor =  await _context.Vendedor.FirstOrDefaultAsync(m => m.VendedorId == id);
            if (vendedor == null)
            {
                return NotFound();
            }
            Vendedor = vendedor;
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

            _context.Attach(Vendedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendedorExists(Vendedor.VendedorId))
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

        private bool VendedorExists(int id)
        {
          return (_context.Vendedor?.Any(e => e.VendedorId == id)).GetValueOrDefault();
        }
    }
}
