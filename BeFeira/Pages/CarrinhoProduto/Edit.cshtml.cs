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

namespace BeFeira.Pages.CarrinhoProduto
{
    public class EditModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraCarrinhoProdutoContext _context;

        public EditModel(BeFeira.Data.BeFeiraCarrinhoProdutoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BeFeira.Models.CarrinhoProduto CarrinhoProduto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CarrinhoProduto == null)
            {
                return NotFound();
            }

            var carrinhoproduto =  await _context.CarrinhoProduto.FirstOrDefaultAsync(m => m.Id == id);
            if (carrinhoproduto == null)
            {
                return NotFound();
            }
            CarrinhoProduto = carrinhoproduto;
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

            _context.Attach(CarrinhoProduto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrinhoProdutoExists(CarrinhoProduto.Id))
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

        private bool CarrinhoProdutoExists(int id)
        {
          return (_context.CarrinhoProduto?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
