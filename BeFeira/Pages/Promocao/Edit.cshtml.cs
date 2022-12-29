using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BeFeira.Data;
using BeFeira.Models;

namespace BeFeira.Pages.Promocao
{
    public class EditModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraPromocaoContext _context;

        public EditModel(BeFeira.Data.BeFeiraPromocaoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BeFeira.Models.Promocao Promocao { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Promocao == null)
            {
                return NotFound();
            }

            var promocao =  await _context.Promocao.FirstOrDefaultAsync(m => m.Id == id);
            if (promocao == null)
            {
                return NotFound();
            }
            Promocao = promocao;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Promocao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PromocaoExists(Promocao.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PromocaoExists(int id)
        {
          return (_context.Promocao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
