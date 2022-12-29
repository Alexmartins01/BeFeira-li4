using System.ComponentModel.DataAnnotations.Schema;

namespace BeFeira.Models
{
    public class VendaProduto
    {
        public int Id { get; set; }
        [ForeignKey("VendaId")]
        public int VendaId{get; set;}
        [ForeignKey("ProdutoId")]
        public int ProdutoId{get; set;}
        public int Quantidade{get; set;}
        public float Preco{get; set;}
        public int TaxaBefeira{get; set;}
    }
}