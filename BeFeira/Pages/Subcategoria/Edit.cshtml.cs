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

namespace BeFeira.Pages.Subcategoria
{
    public class EditModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraSubcategoriaContext _context;

        public EditModel(BeFeira.Data.BeFeiraSubcategoriaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BeFeira.Models.Subcategoria Subcategoria { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Subcategoria == null)
            {
                return NotFound();
            }

            var subcategoria =  await _context.Subcategoria.FirstOrDefaultAsync(m => m.SubCategoriaId == id);
            if (subcategoria == null)
            {
                return NotFound();
            }
            Subcategoria = subcategoria;
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

            _context.Attach(Subcategoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubcategoriaExists(Subcategoria.SubCategoriaId))
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

        private bool SubcategoriaExists(int id)
        {
          return (_context.Subcategoria?.Any(e => e.SubCategoriaId == id)).GetValueOrDefault();
        }
    }
}
