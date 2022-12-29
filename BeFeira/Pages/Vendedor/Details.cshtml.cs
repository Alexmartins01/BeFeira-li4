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
    public class DetailsModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraVendedorContext _context;

        public DetailsModel(BeFeira.Data.BeFeiraVendedorContext context)
        {
            _context = context;
        }

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
    }
}
