using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Feira
{
    public class CreateModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraFeiraContext _context;

        public CreateModel(BeFeira.Data.BeFeiraFeiraContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BeFeira.Models.Feira Feira { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Feira == null || Feira == null)
            {
                return Page();
            }

            _context.Feira.Add(Feira);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
