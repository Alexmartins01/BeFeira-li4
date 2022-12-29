using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Vendedor
{
    public class CreateModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraVendedorContext _context;

        public CreateModel(BeFeira.Data.BeFeiraVendedorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BeFeira.Models.Vendedor Vendedor { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Vendedor == null || Vendedor == null)
            {
                return Page();
            }

            _context.Vendedor.Add(Vendedor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
