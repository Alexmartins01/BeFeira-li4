using System.ComponentModel.DataAnnotations.Schema;

namespace BeFeira.Shared
{
    public class VendaProduto
    {
        public int Id { get; set; }
        [ForeignKey("VendaId")]
        public int VendaId{get; set;}
        [ForeignKey("ProdutoId")]
        public int ProdutoId{get; set;}
        public int Quantidade { get; set; } = 0;
        public float Preco { get; set; } = 0f;
        public int TaxaBefeira { get; set; } = 0;
    }
}