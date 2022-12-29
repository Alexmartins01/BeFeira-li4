using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Stand
{
    public class IndexModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraStandContext _context;

        public IndexModel(BeFeira.Data.BeFeiraStandContext context)
        {
            _context = context;
        }

        public IList<BeFeira.Models.Stand> Stand { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Stand != null)
            {
                Stand = await _context.Stand.ToListAsync();
            }
        }
    }
}
