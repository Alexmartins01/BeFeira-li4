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

namespace BeFeira.Pages.Carrinho
{
    public class EditModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraCarrinhoContext _context;

        public EditModel(BeFeira.Data.BeFeiraCarrinhoContext context)
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

            var carrinho =  await _context.Carrinho.FirstOrDefaultAsync(m => m.CarrinhoId == id);
            if (carrinho == null)
            {
                return NotFound();
            }
            Carrinho = carrinho;
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

            _context.Attach(Carrinho).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrinhoExists(Carrinho.CarrinhoId))
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

        private bool CarrinhoExists(int id)
        {
          return (_context.Carrinho?.Any(e => e.CarrinhoId == id)).GetValueOrDefault();
        }
    }
}
