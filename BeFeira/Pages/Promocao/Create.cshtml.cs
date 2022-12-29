using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Promocao
{
    public class CreateModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraPromocaoContext _context;

        public CreateModel(BeFeira.Data.BeFeiraPromocaoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BeFeira.Models.Promocao Promocao { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Promocao == null || Promocao == null)
            {
                return Page();
            }

            _context.Promocao.Add(Promocao);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
