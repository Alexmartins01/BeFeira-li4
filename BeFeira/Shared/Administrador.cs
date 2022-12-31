using System.ComponentModel.DataAnnotations;

namespace BeFeira.Shared
{

    public class Administrador
    {
        public int AdministradorId { get; set; }
        public string Password { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime Created_at { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime Updated_at { get; set; } = DateTime.Now;
        public string Username { get; set; } = string.Empty;
	}
}
