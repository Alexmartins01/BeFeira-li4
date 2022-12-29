using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Venda
{
    public class DetailsModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraVendaContext _context;

        public DetailsModel(BeFeira.Data.BeFeiraVendaContext context)
        {
            _context = context;
        }

      public BeFeira.Models.Venda Venda { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Venda == null)
            {
                return NotFound();
            }

            var venda = await _context.Venda.FirstOrDefaultAsync(m => m.VendaId == id);
            if (venda == null)
            {
                return NotFound();
            }
            else 
            {
                Venda = venda;
            }
            return Page();
        }
    }
}
