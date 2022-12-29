using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Feira
{
    public class IndexModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraFeiraContext _context;

        public IndexModel(BeFeira.Data.BeFeiraFeiraContext context)
        {
            _context = context;
        }

        public IList<BeFeira.Models.Feira> Feira { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Feira != null)
            {
                Feira = await _context.Feira.ToListAsync();
            }
        }
    }
}
