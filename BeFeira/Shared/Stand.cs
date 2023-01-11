using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFeira.Shared
{
    [Table("Stand")]
    public class Stand
    {
        public int ID { get; set; }

        [ForeignKey("Vendedor")]
        public int? VendedorID { get; set; }

        public string Nome { get; set; }
        public virtual Vendedor? Vendedor { get; set; }

        [ForeignKey("Feira")]
        public int? FeiraID { get; set; }
        public virtual Feira? Feira { get; set; }
    }
}