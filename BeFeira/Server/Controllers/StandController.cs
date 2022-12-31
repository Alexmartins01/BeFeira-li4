using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeFeira.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StandController : ControllerBase
	{
		public static List<Stand> stands = new List<Stand>
		{
			new Stand { StandId= 1, VendedorId = 1, FeiraId = 1},
			new Stand { StandId= 2, VendedorId = 2, FeiraId = 1}
		};

		public static List<Subcategoria> subCategoria = new List<Subcategoria>
		{
			new Subcategoria { SubCategoriaId = 1, Descricao = "Terror", StandId = 1},
			new Subcategoria { SubCategoriaId = 2, Descricao = "Aventura", StandId = 1},
		};

		public static List<Feira> feira = new List<Feira>
		{
			new Feira { FeiraId = 1, Categoria = "Biblioteca"},
			new Feira { FeiraId = 2, Categoria = "Tecnologia"}
		};

		[HttpGet]
		public async Task<ActionResult<List<Stand>>> GetStands()
		{
			return Ok(stands);
		}

		[HttpGet("{id}")]
		[Route("id")]
		public async Task<ActionResult<Stand>> GetSingleStand(int id)
		{
			var stand = stands.FirstOrDefault(s => s.StandId == id);
			if(stand == null)
			{
				return NotFound("No stand here");
			}
			return Ok(stand);
		}
	}
}
