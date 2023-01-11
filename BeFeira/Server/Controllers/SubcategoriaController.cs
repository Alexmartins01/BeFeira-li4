using BeFeira.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcategoriaController : ControllerBase
    {
        private readonly DataContext _context;
        public SubcategoriaController(DataContext context)
        {
            _context = context;
        }




        [HttpGet("")]
        public async Task<ActionResult<List<Subcategoria>>> GetSubcategorias()
        {
            var subs = await _context.Subcategorias.ToListAsync();
            return Ok(subs);
        }


        [HttpGet("{id}")]
        [Route("id")]
        public async Task<ActionResult<List<Subcategoria>>> GetSubcatsByStand(int idStand)
        {
            var feira = await _context.Subcategorias.Where(h=>h.StandID== idStand).ToListAsync();
            if (feira == null)
            {
                return NotFound("Sorry,no Feira Here");
            }
            return Ok(feira);
        }

    }
}
