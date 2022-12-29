using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Administrador
{
    public class IndexModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraContext _context;

        public IndexModel(BeFeira.Data.BeFeiraContext context)
        {
            _context = context;
        }

        public IList<BeFeira.Models.Administrador> Administrador { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Administrador != null)
            {
                Administrador = await _context.Administrador.ToListAsync();
            }
        }
    }
}
