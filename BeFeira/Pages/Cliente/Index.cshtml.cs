using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Cliente
{
    public class IndexModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraClienteContext _context;

        public IndexModel(BeFeira.Data.BeFeiraClienteContext context)
        {
            _context = context;
        }

        public IList<BeFeira.Models.Cliente> Cliente { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cliente != null)
            {
                Cliente = await _context.Cliente.ToListAsync();
            }
        }
    }
}
