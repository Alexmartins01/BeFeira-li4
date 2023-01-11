using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeFeira.Shared
{


    [Table("Carrinho")]
    public class Carrinho
    {
        public int ID { get; set; }

        [ForeignKey("Cliente")]
        public int? ClienteID { get; set; }
        public virtual Cliente? Cliente { get; set; }

        [ForeignKey("Stand")]
        public int StandID { get; set; }
        public virtual Stand Stand { get; set; }
        public decimal Total { get; set; } = 0;
    }
}