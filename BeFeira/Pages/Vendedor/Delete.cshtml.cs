using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Vendedor
{
    public class DeleteModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraVendedorContext _context;

        public DeleteModel(BeFeira.Data.BeFeiraVendedorContext context)
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

            var vendedor = await _context.Vendedor.FirstOrDefaultAsync(m => m.VendedorId == id);

            if (vendedor == null)
            {
                return NotFound();
            }
            else 
            {
                Vendedor = vendedor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Vendedor == null)
            {
                return NotFound();
            }
            var vendedor = await _context.Vendedor.FindAsync(id);

            if (vendedor != null)
            {
                Vendedor = vendedor;
                _context.Vendedor.Remove(Vendedor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
