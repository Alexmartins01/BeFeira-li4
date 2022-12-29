using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BefeiraBlazor.Models
{


    public class CarrinhoProduto
    {
        [ForeignKey("CarrinhoId")]
        public int CarrinhoId { get; set; }
        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public float Preco { get; set; }
        public int TaxaBefeira { get; set; }
    }
}
