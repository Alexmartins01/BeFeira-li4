using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.CarrinhoProduto
{
    public class CreateModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraCarrinhoProdutoContext _context;

        public CreateModel(BeFeira.Data.BeFeiraCarrinhoProdutoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BeFeira.Models.CarrinhoProduto CarrinhoProduto { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.CarrinhoProduto == null || CarrinhoProduto == null)
            {
                return Page();
            }

            _context.CarrinhoProduto.Add(CarrinhoProduto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
