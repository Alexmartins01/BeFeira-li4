using BeFeira.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CarrinhoProdController : Controller
    {
        private readonly DataContext _context;

        public CarrinhoProdController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<CarrinhoProduto>>> GetCarrinhosProd()
        {
            var carprod = await _context.CarrinhoProdutos.Include(h=>h.Produto).ToListAsync();
            return Ok(carprod);
        }

        [HttpGet("{id}")]
        [Route("id")]
        public async Task<ActionResult<CarrinhoProduto>> GetCarrinhosProdbyKartId(int id)
        {
            var cars = await _context.CarrinhoProdutos.FirstOrDefaultAsync(h => h.CarrinhoID == id);
            if (cars == null)
            {
                return NotFound("Sorry,no CarrinhoProd");
            }
            return Ok(cars);
        }

        [HttpPost]
        public async Task<ActionResult<CarrinhoProduto>> addCarrinhoProduto(CarrinhoProduto p)
        {

            _context.CarrinhoProdutos.Add(p);
            await _context.SaveChangesAsync();

            return Ok(await GetDBCarrinhoProduto());
        }

        private async Task<List<CarrinhoProduto>> GetDBCarrinhoProduto()
        {

            return await _context.CarrinhoProdutos.ToListAsync();
        }

        [HttpDelete("{id}")]
        [Route("id")]
        public async Task<ActionResult<CarrinhoProduto>> DeleteCarrinhoProd( int id)
        {

            var dbProd = await _context.CarrinhoProdutos.FirstOrDefaultAsync(sh => sh.ID == id);

            if (dbProd == null)
                return NotFound("No CarrinhoProd ");

            _context.CarrinhoProdutos.Remove(dbProd);
            await _context.SaveChangesAsync();
            return Ok(await GetDBCarrinhoProduto());
        }
    }
}
