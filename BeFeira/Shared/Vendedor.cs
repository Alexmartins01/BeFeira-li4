using System.ComponentModel.DataAnnotations;

namespace BeFeira.Shared
{
    public class Vendedor
    {
        [Key]
        public int VendedorId { get; set; }
        public string Iban { get; set; } = string.Empty;
        public string Mbway { get; set; } = string.Empty;
		public string Username { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
        public int Rating { get; set; } = 0;
        public string Email { get; set; } = string.Empty;
	}
}