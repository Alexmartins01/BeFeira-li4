using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFeira.Shared
{
    [Table("VendaProduto")]
    public class VendaProduto
    {
        public int ID { get; set; }
        [ForeignKey("Venda")]
        public int? VendaID { get; set; }
        public virtual Venda? Venda { get; set; }

        [ForeignKey("Produto")]
        public int? ProdutoID { get; set; }
        public virtual Produto? Produto { get; set; }


        public int Quantidade { get; set; } = 0;
        public float Preco { get; set; } = 0f;
        public int TaxaBefeira { get; set; } = 0;
    }
}