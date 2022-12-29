using System.ComponentModel.DataAnnotations;

namespace BefeiraBlazor.Models
{
    

    public class Administrador
    {
        public int AdministradorId { get; set; }
        public string? Password { get; set; }
        [DataType(DataType.Date)]
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public string? Username { get; set; }
    }
}
