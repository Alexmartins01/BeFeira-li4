using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Subcategoria
{
    public class CreateModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraSubcategoriaContext _context;

        public CreateModel(BeFeira.Data.BeFeiraSubcategoriaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BeFeira.Models.Subcategoria Subcategoria { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Subcategoria == null || Subcategoria == null)
            {
                return Page();
            }

            _context.Subcategoria.Add(Subcategoria);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
