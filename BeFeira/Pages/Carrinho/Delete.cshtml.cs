using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Carrinho
{
    public class DeleteModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraCarrinhoContext _context;

        public DeleteModel(BeFeira.Data.BeFeiraCarrinhoContext context)
        {
            _context = context;
        }

        [BindProperty]
      public BeFeira.Models.Carrinho Carrinho { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Carrinho == null)
            {
                return NotFound();
            }

            var carrinho = await _context.Carrinho.FirstOrDefaultAsync(m => m.CarrinhoId == id);

            if (carrinho == null)
            {
                return NotFound();
            }
            else 
            {
                Carrinho = carrinho;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Carrinho == null)
            {
                return NotFound();
            }
            var carrinho = await _context.Carrinho.FindAsync(id);

            if (carrinho != null)
            {
                Carrinho = carrinho;
                _context.Carrinho.Remove(Carrinho);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
