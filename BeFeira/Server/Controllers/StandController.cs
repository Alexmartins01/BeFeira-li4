using BeFeira.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StandController : ControllerBase
	{

       
            private readonly DataContext _context;

            public StandController(DataContext context)
            {
                _context = context;
            }


            [HttpGet]
		public async Task<ActionResult<List<Stand>>> GetStands()
		{
            var stands = await _context.Stands.Include(std=>std.Vendedor).Include(std=>std.Feira).ToListAsync();
            return Ok(stands);
		}

		[HttpGet("{id}")]
		[Route("id")]
		public async Task<ActionResult<Stand>> GetSingleStand(int id)
		{
            var prod = await _context.Stands.FirstOrDefaultAsync(h => h.ID == id);
            if (prod == null)
            {
                return NotFound("Sorry,no productHere");
            }
            return Ok(prod);
        }


		[HttpPost]
		public async Task<ActionResult<Stand>> addStand(Stand p)
		{

			_context.Stands.Add(p);
			await _context.SaveChangesAsync();

			return Ok(await GetDBStands());
		}

		private async Task<List<Stand>> GetDBStands()
		{

			return await _context.Stands.ToListAsync();
		}

	}
}
