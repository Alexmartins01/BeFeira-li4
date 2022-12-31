using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BeFeira.Shared
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [ForeignKey("IdStand")]
        public int StandId { get; set; }
        public float Preco { get; set; } = 0f;
        public int Promocao { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public int Rating { get; set; } = 0;
        [ForeignKey("SubCategoria")]
        public Subcategoria? SubCategoria { get; set; }
    }
}

