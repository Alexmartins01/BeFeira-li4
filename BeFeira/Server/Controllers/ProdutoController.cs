using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BeFeira.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly DataContext _context;

            public ProdutoController(DataContext context) 
        {
            _context = context;
        }



        [HttpGet]
        public async Task <ActionResult<List<Produto>>> GetProdutos()
        {
            var produto = await _context.Produtos.Include(h=>h.Stand).Include(h => h.Stand.Feira).ToListAsync();
            return Ok(produto);
        }

        [HttpGet("{id}")]
        [Route("id")]
        public async Task<ActionResult<Produto>> GetSingleProd(int id)
        {
            var prod = await _context.Produtos.FirstOrDefaultAsync(h => h.ID == id);
            if (prod == null)
            {
                return NotFound("Sorry,no productHere");
            }
            return Ok(prod);
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> CreateProduto(Produto p)
        {

            _context.Produtos.Add(p);
            await _context.SaveChangesAsync();

            return Ok(await GetDbProdutos());
        }

        private async Task<List<Produto>> GetDbProdutos()
        {

            return await _context.Produtos.ToListAsync();
        }







    }
}
