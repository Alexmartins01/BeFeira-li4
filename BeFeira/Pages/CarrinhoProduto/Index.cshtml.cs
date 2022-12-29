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
    public class IndexModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraCarrinhoProdutoContext _context;

        public IndexModel(BeFeira.Data.BeFeiraCarrinhoProdutoContext context)
        {
            _context = context;
        }

        public IList<BeFeira.Models.CarrinhoProduto> CarrinhoProduto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CarrinhoProduto != null)
            {
                CarrinhoProduto = await _context.CarrinhoProduto.ToListAsync();
            }
        }
    }
}
