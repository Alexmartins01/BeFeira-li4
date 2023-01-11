using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFeira.Shared
{
    [Table("Stand")]
    public class Stand
    {
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        [ForeignKey("Vendedor")]
        public int VendedorID { get; set; }

        [ForeignKey("Feira")]
        public int FeiraID { get; set; }
    }
}