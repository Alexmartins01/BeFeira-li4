using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Subcategoria
{
    public class IndexModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraSubcategoriaContext _context;

        public IndexModel(BeFeira.Data.BeFeiraSubcategoriaContext context)
        {
            _context = context;
        }

        public IList<BeFeira.Models.Subcategoria> Subcategoria { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Subcategoria != null)
            {
                Subcategoria = await _context.Subcategoria.ToListAsync();
            }
        }
    }
}
