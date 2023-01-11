using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFeira.Shared
{
    [Table("Promocao")]
    public class Promocao
    {
        public int ID { get; set; }

        [ForeignKey("Produto")]
        public int? ProdutoID { get; set; }
        public virtual Produto? Produto { get; set; }


        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now;
        public int Desconto { get; set; } = 0;
    }
}