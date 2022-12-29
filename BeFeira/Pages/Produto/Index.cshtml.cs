using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Produto
{
    public class IndexModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraProdutoContext _context;

        public IndexModel(BeFeira.Data.BeFeiraProdutoContext context)
        {
            _context = context;
        }

        public IList<BeFeira.Models.Produto> Produto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Produto != null)
            {
                Produto = await _context.Produto.ToListAsync();
            }
        }
    }
}
