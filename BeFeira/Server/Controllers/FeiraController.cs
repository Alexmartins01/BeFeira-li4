using BeFeira.Server.Data;
using BeFeira.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeiraController : ControllerBase
    {
        private readonly DataContext _context;
        public FeiraController(DataContext context)
        {
            _context = context;
        }




        [HttpGet("")]
        public async Task<ActionResult<List<Feira>>> GetFeiras()
        {
            var feiras = await _context.Feiras.ToListAsync();
            return Ok(feiras);
        }

        [HttpGet("{id}")]
        [Route("id")]
        public async Task<ActionResult<Feira>> GetSingleFeira(int id)
        {
            var feira = await _context.Feiras.FirstOrDefaultAsync(h => h.ID == id);
            if (feira == null)
            {
                return NotFound("Sorry,no Feira Here");
            }
            return Ok(feira);
        }

        [HttpPost]
        public async Task<ActionResult<Feira>> CreateFeira(Feira p)
        {

            _context.Feiras.Add(p);
            await _context.SaveChangesAsync();

            return Ok(await GetDBFeiras());
        }



        [HttpPut("{id}")]
        [Route("id")]
        public async Task<ActionResult<Feira>> UpdateFeira(Feira p, int id)
        {

            var dbFeira = await _context.Feiras.FirstOrDefaultAsync(sh => sh.ID == id);

            if (dbFeira == null)
                return NotFound("No Feira ");

            dbFeira.ID = p.ID;
            dbFeira.Categoria = p.Categoria;
            await _context.SaveChangesAsync();
            return Ok(await GetDBFeiras());
        }


        [HttpDelete("{id}")]
        [Route("id")]
        public async Task<ActionResult<Feira>> DeleteFeira(Feira p, int id)
        {

            var dbProd = await _context.Feiras.FirstOrDefaultAsync(sh => sh.ID == id);

            if (dbProd == null)
                return NotFound("No product ");



            _context.Feiras.Remove(dbProd);
            return Ok(await GetDBFeiras());
        }

        private async Task<List<Feira>> GetDBFeiras()
        {

            return await _context.Feiras.ToListAsync();
        }


    }


}
