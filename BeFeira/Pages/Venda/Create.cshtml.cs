using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Venda
{
    public class CreateModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraVendaContext _context;

        public CreateModel(BeFeira.Data.BeFeiraVendaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BeFeira.Models.Venda Venda { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Venda == null || Venda == null)
            {
                return Page();
            }

            _context.Venda.Add(Venda);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
