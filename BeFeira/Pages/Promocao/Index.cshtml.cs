using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Promocao
{
    public class IndexModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraPromocaoContext _context;

        public IndexModel(BeFeira.Data.BeFeiraPromocaoContext context)
        {
            _context = context;
        }

        public IList<BeFeira.Models.Promocao> Promocao { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Promocao != null)
            {
                Promocao = await _context.Promocao.ToListAsync();
            }
        }
    }
}
