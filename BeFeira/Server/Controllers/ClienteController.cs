using BeFeira.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly DataContext _context;

        public ClienteController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> GetClientes()
        {
            var cliente = await _context.Clientes.ToListAsync();
            return Ok(cliente);
        }
       
        [HttpGet("{id}")]
        [Route("id")]
        public async Task<ActionResult<Cliente>> GetSingleCliente(int id)
        {
            var cli = await _context.Clientes.FirstOrDefaultAsync(h => h.ID == id);
            if (cli == null)
            {
                return NotFound("Sorry,no Client");
            }
            return Ok(cli);
        }


        [HttpPost]
        public async Task<ActionResult<List<Cliente>>> addCliente(Cliente c)
        {

            _context.Clientes.Add(c);
            await _context.SaveChangesAsync();

            return Ok(_context.Clientes);
        }

        private async Task<List<Cliente>> getDBClientes()
        {

            return await _context.Clientes.ToListAsync();
        }









    }
}
