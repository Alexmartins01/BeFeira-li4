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

namespace BeFeira.Pages.VendaProduto
{
    public class EditModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraVendaProdutoContext _context;

        public EditModel(BeFeira.Data.BeFeiraVendaProdutoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BeFeira.Models.VendaProduto VendaProduto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.VendaProduto == null)
            {
                return NotFound();
            }

            var vendaproduto =  await _context.VendaProduto.FirstOrDefaultAsync(m => m.Id == id);
            if (vendaproduto == null)
            {
                return NotFound();
            }
            VendaProduto = vendaproduto;
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

            _context.Attach(VendaProduto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendaProdutoExists(VendaProduto.Id))
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

        private bool VendaProdutoExists(int id)
        {
          return (_context.VendaProduto?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
