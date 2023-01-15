using BeFeira.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : Controller
    {


        private readonly DataContext _context;

        public VendaController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Venda>>> GetVendas()
        {
            var vendas = await _context.Vendas.Include(car => car.Carrinho).ToListAsync();
            return Ok(vendas);
        }

        [HttpGet("{id}")]
        [Route("id")]
        public async Task<ActionResult<Venda>> GetVenda(int id)
        {
            var carrinho = await _context.Vendas.FirstOrDefaultAsync(h => h.ID == id);
            if (carrinho == null)
            {
                return NotFound("Sorry,no Kart");
            }
            return Ok(carrinho);
        }

        [HttpPost]
        public async Task<ActionResult<Venda>> addVenda(Venda p)
        {

            _context.Vendas.Add(p);
            await _context.SaveChangesAsync();

            return Ok(await GetDBVendas());
        }



        private async Task<List<Venda>> GetDBVendas()
        {

            return await _context.Vendas.ToListAsync();
        }

    }
}
