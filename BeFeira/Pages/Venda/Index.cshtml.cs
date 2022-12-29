using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Venda
{
    public class IndexModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraVendaContext _context;

        public IndexModel(BeFeira.Data.BeFeiraVendaContext context)
        {
            _context = context;
        }

        public IList<BeFeira.Models.Venda> Venda { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Venda != null)
            {
                Venda = await _context.Venda.ToListAsync();
            }
        }
    }
}
