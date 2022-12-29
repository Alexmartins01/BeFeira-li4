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
    public class DetailsModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraSubcategoriaContext _context;

        public DetailsModel(BeFeira.Data.BeFeiraSubcategoriaContext context)
        {
            _context = context;
        }

      public BeFeira.Models.Subcategoria Subcategoria { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Subcategoria == null)
            {
                return NotFound();
            }

            var subcategoria = await _context.Subcategoria.FirstOrDefaultAsync(m => m.SubCategoriaId == id);
            if (subcategoria == null)
            {
                return NotFound();
            }
            else 
            {
                Subcategoria = subcategoria;
            }
            return Page();
        }
    }
}
