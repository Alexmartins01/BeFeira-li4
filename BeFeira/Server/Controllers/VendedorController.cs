using BeFeira.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : Controller
    {

        private readonly DataContext _context;

        public VendedorController(DataContext context)
        {
            _context = context;
        }



        [HttpGet]
        public async Task<ActionResult<List<Vendedor>>> GetVendedor()
        {
            var vendedor = await _context.Vendedores.ToListAsync();
            return Ok(vendedor);
        }


        [HttpGet("{id}")]
        [Route("id")]
        public async Task<ActionResult<Vendedor>> GetSingleVendedor(int id)
        {
            var vendedor = await _context.Vendedores.FirstOrDefaultAsync(h => h.ID == id);
            if (vendedor == null)
            {
                return NotFound("Sorry,no Seller");
            }
            return Ok(vendedor);
        }


    }
}
