using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.CarrinhoProduto
{
    public class DeleteModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraCarrinhoProdutoContext _context;

        public DeleteModel(BeFeira.Data.BeFeiraCarrinhoProdutoContext context)
        {
            _context = context;
        }

        [BindProperty]
      public BeFeira.Models.CarrinhoProduto CarrinhoProduto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CarrinhoProduto == null)
            {
                return NotFound();
            }

            var carrinhoproduto = await _context.CarrinhoProduto.FirstOrDefaultAsync(m => m.Id == id);

            if (carrinhoproduto == null)
            {
                return NotFound();
            }
            else 
            {
                CarrinhoProduto = carrinhoproduto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CarrinhoProduto == null)
            {
                return NotFound();
            }
            var carrinhoproduto = await _context.CarrinhoProduto.FindAsync(id);

            if (carrinhoproduto != null)
            {
                CarrinhoProduto = carrinhoproduto;
                _context.CarrinhoProduto.Remove(CarrinhoProduto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
