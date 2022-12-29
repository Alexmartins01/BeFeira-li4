using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Produto
{
    public class CreateModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraProdutoContext _context;

        public CreateModel(BeFeira.Data.BeFeiraProdutoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BeFeira.Models.Produto Produto { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Produto == null || Produto == null)
            {
                return Page();
            }

            _context.Produto.Add(Produto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
