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


        [HttpPut("{id}")]
        [Route("id")]
        public async Task<ActionResult<Produto>> UpdateProduto(Produto p,int id)
        {

            Console.WriteLine(p.ID);
            var dbprod = await _context.Produtos.FirstOrDefaultAsync(sh => sh.ID == p.ID);

            if (dbprod == null)
                return NotFound("No Vendedor ");

            dbprod.Preco = p.Preco;
            dbprod.Stock = p.Stock;
            dbprod.StandID = p.StandID;
            dbprod.Rating = p.Rating;
            dbprod.Promocao = p.Promocao;
            dbprod.SubCategoriaID = p.SubCategoriaID;
            dbprod.UrlImage = p.UrlImage;
            dbprod.Nome_Produto = p.Nome_Produto;

           

            await _context.SaveChangesAsync();
            Console.WriteLine("adicionei");
            return Ok(await GetDbProdutos());

        }

        private async Task<List<Produto>> GetDbProdutos()
        {

            return await _context.Produtos.ToListAsync();
        }







    }
}
