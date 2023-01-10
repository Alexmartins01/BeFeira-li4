using BeFeira.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeFeira.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeiraController : ControllerBase
    {
        public static List<Feira> feiras = new List<Feira>
        {
            new Feira { FeiraId = 1, Categoria = "Biblioteca"},
            new Feira { FeiraId = 2, Categoria = "Tecnologia"}
        };



        [HttpGet("{id}")]
        public async Task<ActionResult<List<Feira>>> GetFeiras()
        {
            return Ok(feiras);
        }

        [HttpGet("{id}")]
        [Route("id")]
        public async Task<ActionResult<Feira>> GetSingleFeira(int id)
        {
            var stand = feiras.FirstOrDefault(s => s.FeiraId == id);
            if (stand == null)
            {
                return NotFound("No feira here");
            }
            return Ok(stand);
        }
    }

    
}
