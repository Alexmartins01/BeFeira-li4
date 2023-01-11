using System.ComponentModel.DataAnnotations.Schema;

namespace BeFeira.Shared
{
    [Table("Cliente")]
    public class Cliente
    {
        public int ID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
	}
}


