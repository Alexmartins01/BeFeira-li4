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
    public class DetailsModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraPromocaoContext _context;

        public DetailsModel(BeFeira.Data.BeFeiraPromocaoContext context)
        {
            _context = context;
        }

      public BeFeira.Models.Promocao Promocao { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Promocao == null)
            {
                return NotFound();
            }

            var promocao = await _context.Promocao.FirstOrDefaultAsync(m => m.Id == id);
            if (promocao == null)
            {
                return NotFound();
            }
            else 
            {
                Promocao = promocao;
            }
            return Page();
        }
    }
}
