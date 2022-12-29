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
    public class IndexModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraVendaProdutoContext _context;

        public IndexModel(BeFeira.Data.BeFeiraVendaProdutoContext context)
        {
            _context = context;
        }

        public IList<BeFeira.Models.VendaProduto> VendaProduto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.VendaProduto != null)
            {
                VendaProduto = await _context.VendaProduto.ToListAsync();
            }
        }
    }
}
