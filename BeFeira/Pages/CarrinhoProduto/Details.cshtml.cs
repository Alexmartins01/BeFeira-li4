using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.CarrinhoProduto
{
    public class DetailsModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraCarrinhoProdutoContext _context;

        public DetailsModel(BeFeira.Data.BeFeiraCarrinhoProdutoContext context)
        {
            _context = context;
        }

      public BeFeira.Models.CarrinhoProduto CarrinhoProduto { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CarrinhoProduto == null)
            {
                return NotFound();
            }

            var carrinhoproduto = await _context.CarrinhoProduto.FirstOrDefaultAsync(m => m.Id == id);
            if (carrinhoproduto == null)
            {
                return NotFound();
            }
            else 
            {
                CarrinhoProduto = carrinhoproduto;
            }
            return Page();
        }
    }
}
