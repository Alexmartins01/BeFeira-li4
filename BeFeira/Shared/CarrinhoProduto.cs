using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeFeira.Shared
{


    public class CarrinhoProduto
    {
        public int Id { get; set; }
        [ForeignKey("CarrinhoId")]
        public int CarrinhoId { get; set; }
        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; } = 0;
        public float Preco { get; set; } = 0f;
        public int TaxaBefeira { get; set; } = 0;
    }
}
