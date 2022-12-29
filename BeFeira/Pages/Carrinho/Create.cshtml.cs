using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Carrinho
{
    public class CreateModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraCarrinhoContext _context;

        public CreateModel(BeFeira.Data.BeFeiraCarrinhoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BeFeira.Models.Carrinho Carrinho { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Carrinho == null || Carrinho == null)
            {
                return Page();
            }

            _context.Carrinho.Add(Carrinho);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
