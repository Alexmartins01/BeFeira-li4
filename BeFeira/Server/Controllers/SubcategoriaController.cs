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


       

    }
}
