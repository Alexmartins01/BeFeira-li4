using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BeFeira.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [ForeignKey("IdStand")]
        public int IdStand { get; set; }
        public float Preco { get; set; }
        public int? Promocao { get; set; }
        public int Stock { get; set; }
        public int? Rating { get; set; }
        [ForeignKey("SubCategoria")]
        public int SubCategoria { get; set; }
    }
}

