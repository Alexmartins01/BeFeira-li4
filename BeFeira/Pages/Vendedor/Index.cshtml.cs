using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Vendedor
{
    public class IndexModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraVendedorContext _context;

        public IndexModel(BeFeira.Data.BeFeiraVendedorContext context)
        {
            _context = context;
        }

        public IList<BeFeira.Models.Vendedor> Vendedor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Vendedor != null)
            {
                Vendedor = await _context.Vendedor.ToListAsync();
            }
        }
    }
}
