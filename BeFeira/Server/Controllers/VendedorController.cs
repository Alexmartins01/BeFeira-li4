using BeFeira.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

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
        public async Task<ActionResult<List<Vendedor>>> GetVendedores()
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

		[HttpPost]
		public async Task<ActionResult<Vendedor>> addVendedor(Vendedor p)
		{

			_context.Vendedores.Add(p);
			await _context.SaveChangesAsync();

			return Ok(await GetDBVendedores());
		}


		[HttpPut]
		public async Task<ActionResult<Vendedor>> UpdateVendedor(Vendedor p)
		{

			var dbVend = await _context.Vendedores.FirstOrDefaultAsync(sh => sh.ID == p.ID);

			if (dbVend == null)
				return NotFound("No Vendedor ");

			dbVend.Email = p.Email;
			dbVend.Password = p.Password;
			dbVend.Mbway = p.Mbway;
			dbVend.Rating = p.Rating;
			dbVend.Username = p.Username;
			dbVend.Iban = p.Iban;
			dbVend.ID = p.ID;


			await _context.SaveChangesAsync();
			return Ok(await GetDBVendedores());
		}


		[HttpDelete("{id}")]
		[Route("id")]
		public async Task<ActionResult<Vendedor>> DeleteVendedor(Vendedor p, int id)
		{

			var dbProd = await _context.Vendedores.FirstOrDefaultAsync(sh => sh.ID == id);

			if (dbProd == null)
				return NotFound("No Vendedor ");



			_context.Vendedores.Remove(dbProd);
			return Ok(await GetDBVendedores());
		}

		private async Task<List<Vendedor>> GetDBVendedores()
		{

			return await _context.Vendedores.ToListAsync();
		}




	}
}
