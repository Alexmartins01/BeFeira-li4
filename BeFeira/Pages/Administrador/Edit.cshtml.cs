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

namespace BeFeira.Pages.Administrador
{
    public class EditModel : PageModel
    {
        private readonly BeFeira.Data.BeFeiraContext _context;

        public EditModel(BeFeira.Data.BeFeiraContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BeFeira.Models.Administrador Administrador { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Administrador == null)
            {
                return NotFound();
            }

            var administrador =  await _context.Administrador.FirstOrDefaultAsync(m => m.AdministradorId == id);
            if (administrador == null)
            {
                return NotFound();
            }
            Administrador = administrador;
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

            _context.Attach(Administrador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdministradorExists(Administrador.AdministradorId))
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

        private bool AdministradorExists(int id)
        {
          return (_context.Administrador?.Any(e => e.AdministradorId == id)).GetValueOrDefault();
        }
    }
}
