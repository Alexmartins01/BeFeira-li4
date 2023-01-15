using BeFeira.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace BeFeira.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrinhoController : Controller
    {
            private readonly DataContext _context;

            public CarrinhoController(DataContext context)
            {
                _context = context;
            }
        
        [HttpGet]
        public async Task<ActionResult<List<Carrinho>>> GetCarrinho()
        {
            var cars = await _context.Carrinhos.Include(car => car.Cliente).ToListAsync();
            return Ok(cars);
        }

        [HttpGet("{id}")]
        [Route("id")]
        public async Task<ActionResult<Vendedor>> GetCarrinhobyIDCLI(int id)
        {
            var carrinho = await _context.Carrinhos.FirstOrDefaultAsync(h => h.ClienteID == id);
            if (carrinho == null)
            {
                return NotFound("Sorry,no Kart");
            }
            return Ok(carrinho);
        }

        [HttpPost]
        public async Task<ActionResult<Carrinho>> addCarrinho(Carrinho p)
        {

            _context.Carrinhos.Add(p);
            await _context.SaveChangesAsync();

            return Ok(await GetDBcarrinhos());
        }

        [HttpDelete("{id}")]
        [Route("id")]
        public async Task<ActionResult<Carrinho>> DeleteCarrinho(Carrinho p, int id)
        {

            var dbCarrinho = await _context.Carrinhos.FirstOrDefaultAsync(sh => sh.ID == id);

            if (dbCarrinho == null)
                return NotFound("No Carrinho ");



            _context.Carrinhos.Remove(dbCarrinho);
            return Ok(await GetDBcarrinhos());
        }


        [HttpPut("{id}")]
        [Route("id")]
        public async Task<ActionResult<List<Carrinho>>> UpdateCarrinho(Carrinho p, int id)
        {

            var dbCarrinho = await _context.Carrinhos.FirstOrDefaultAsync(sh => sh.ID == id);

            if (dbCarrinho == null)
                return NotFound("No Carrinho ");

            dbCarrinho.ClienteID = p.ClienteID;
            dbCarrinho.Total = p.Total;
            dbCarrinho.ID = p.ID;

            await _context.SaveChangesAsync();
            return Ok(await GetDBcarrinhos());



            
        }


        private async Task<List<Carrinho>> GetDBcarrinhos()
        {

            return await _context.Carrinhos.ToListAsync();
        }




    }
}
