using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeFeira.Models
{


    public class CarrinhoProduto
    {
        public int Id { get; set; }
        [ForeignKey("CarrinhoId")]
        public int CarrinhoId { get; set; }
        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public float Preco { get; set; }
        public int TaxaBefeira { get; set; }
    }
}
