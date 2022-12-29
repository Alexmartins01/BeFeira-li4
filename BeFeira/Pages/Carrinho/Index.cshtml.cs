using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Carrinho
{
    public class IndexModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraCarrinhoContext _context;

        public IndexModel(BeFeira.Data.BeFeiraCarrinhoContext context)
        {
            _context = context;
        }

        public IList<BeFeira.Models.Carrinho> Carrinho { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Carrinho != null)
            {
                Carrinho = await _context.Carrinho.ToListAsync();
            }
        }
    }
}
