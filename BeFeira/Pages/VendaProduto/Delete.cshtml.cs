using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.VendaProduto
{
    public class DeleteModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraVendaProdutoContext _context;

        public DeleteModel(BeFeira.Data.BeFeiraVendaProdutoContext context)
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

            var vendaproduto = await _context.VendaProduto.FirstOrDefaultAsync(m => m.Id == id);

            if (vendaproduto == null)
            {
                return NotFound();
            }
            else 
            {
                VendaProduto = vendaproduto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.VendaProduto == null)
            {
                return NotFound();
            }
            var vendaproduto = await _context.VendaProduto.FindAsync(id);

            if (vendaproduto != null)
            {
                VendaProduto = vendaproduto;
                _context.VendaProduto.Remove(VendaProduto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
