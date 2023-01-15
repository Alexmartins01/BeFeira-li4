using BeFeira.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcategoriaController : Controller
    {
        private readonly DataContext _context;
        public SubcategoriaController(DataContext context)
        {
            _context = context;
        }




        [HttpGet]
        public async Task<ActionResult<List<Subcategoria>>> GetSubcategorias()
        {
            var subs = await _context.Subcategorias.ToListAsync();
            return Ok(subs);
        }



        [HttpGet("{id}")]
        [Route("id")]
        public async Task<ActionResult<Subcategoria>> GetSingleSubCat(int id)
        {
            var subcat = await _context.Subcategorias.FirstOrDefaultAsync(h => h.ID == id);
            if (subcat == null)
            {
                return NotFound("Sorry,no subcat here");
            }
            return Ok(subcat);
        }

        
        [HttpPost]
        public async Task<ActionResult<Subcategoria>> CreateSubcategoria(Subcategoria s)
        {

            _context.Subcategorias.Add(s);
            await _context.SaveChangesAsync();

            return Ok(await GetDBSubcats());
        }

        private async Task<List<Subcategoria>> GetDBSubcats()
        {

            return await _context.Subcategorias.ToListAsync();
        }


    }
}
