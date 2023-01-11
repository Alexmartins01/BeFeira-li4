using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeFeira.Shared
{

    [Table("CarrinhoProduto")]
    public class CarrinhoProduto
    {
        public int ID { get; set; }

        [ForeignKey("Carrinho")]
        public int? CarrinhoID { get; set; }
        public virtual Carrinho? Carrinho { get; set; }

        [ForeignKey("Produto")]
        public int? ProdutoID { get; set; }
        public virtual Produto? Produto { get; set; }

        public int Quantidade { get; set; } = 0;
        public float Preco { get; set; } = 0f;
        public int TaxaBefeira { get; set; } = 0;
    }
}