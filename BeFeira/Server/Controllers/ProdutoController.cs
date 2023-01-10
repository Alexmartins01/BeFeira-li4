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



        [HttpGet("")]
        public async Task <ActionResult<List<Produto>>> GetProdutos()
        {
            var produto = await _context.Produtos.ToListAsync();
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

            return Ok(await GetDBProds());
        }


        [HttpGet("{id}")]
        [Route("id")]
        public async Task<ActionResult<Produto>> UpdateProduto(Produto p,int id)
        {

            var dbProd = await _context.Produtos.FirstOrDefaultAsync(sh=>sh.ID==id);

            if (dbProd == null)
                return NotFound("No product ");

            dbProd.Preco = p.Preco;
            dbProd.ID = id;
            dbProd.Promocao = p.Promocao;
            dbProd.Nome_Produto = p.Nome_Produto;
            dbProd.Rating = p.Rating;
            dbProd.StandID = p.StandID;
            dbProd.SubCategoriaID = p.SubCategoriaID;
            dbProd.Stock = p.Stock;

            await _context.SaveChangesAsync();
            return Ok(await GetDBProds());
            }


        [HttpDelete("{id}")]
        [Route("id")]
        public async Task<ActionResult<Produto>> DeleteProduto(Produto p, int id)
        {

            var dbProd = await _context.Produtos.FirstOrDefaultAsync(sh => sh.ID == id);

            if (dbProd == null)
                return NotFound("No product ");

          

             _context.Produtos.Remove(dbProd);
            return Ok(await GetDBProds());
        }

        private async Task<List<Produto>> GetDBProds()
        {

            return await _context.Produtos.ToListAsync();
        }



    }
}
