using BeFeira.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Vendaprodutocontroller : Controller
    {

        private readonly DataContext _context;

        public Vendaprodutocontroller(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<VendaProduto>>> GetVendasProd()
        {
            var vendas = await _context.VendaProdutos.Include(car => car.Produto).ToListAsync();
            return Ok(vendas);
        }


        [HttpGet("{id}")]
        [Route("id")]
        public async Task<ActionResult<VendaProduto>> GetVendaProduto(int id)
        {
            var carrinho = await _context.VendaProdutos.FirstOrDefaultAsync(h => h.ID == id);
            if (carrinho == null)
            {
                return NotFound("Sorry,no Venda");
            }
            return Ok(carrinho);
        }

        [HttpPost]
        public async Task<ActionResult<VendaProduto>> addVendaProduto(VendaProduto p)
        {

            _context.VendaProdutos.Add(p);
            await _context.SaveChangesAsync();

            return Ok(await GetDBVendasProd());
        }

        private async Task<List<VendaProduto>> GetDBVendasProd()
        {

            return await _context.VendaProdutos.ToListAsync();
        }



    }
}
