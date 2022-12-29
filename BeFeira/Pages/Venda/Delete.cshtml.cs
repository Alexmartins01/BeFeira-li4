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
    public class DeleteModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraVendaContext _context;

        public DeleteModel(BeFeira.Data.BeFeiraVendaContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Venda == null)
            {
                return NotFound();
            }
            var venda = await _context.Venda.FindAsync(id);

            if (venda != null)
            {
                Venda = venda;
                _context.Venda.Remove(Venda);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
