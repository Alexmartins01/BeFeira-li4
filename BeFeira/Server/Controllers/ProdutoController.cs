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


    


    }
}
