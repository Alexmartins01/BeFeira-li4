using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeFeira.Shared
{


    public class Carrinho
    {
        [Key]
        public int CarrinhoId { get; set; }
        [ForeignKey("ClienteId")]
        public int ClienteId { get; set; }
        [ForeignKey("StandId")]
        public int StandId { get; set; }
        public decimal Total { get; set; } = 0;
    }
}
