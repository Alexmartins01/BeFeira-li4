using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFeira.Shared
{

    [Table("Administrador")]
    public class Administrador
    {
        public int ID { get; set; }
        public string Password { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime Created_at { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime Updated_at { get; set; } = DateTime.Now;
        public string Username { get; set; } = string.Empty;
    }
}