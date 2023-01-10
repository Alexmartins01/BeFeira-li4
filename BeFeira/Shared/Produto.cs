using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BeFeira.Shared
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Stand")]
        public int StandID { get; set; }

        public String Nome_Produto { get; set; } 
        public float Preco { get; set; } = 0f;
        public int Promocao { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public int Rating { get; set; } = 0;
        [ForeignKey("SubCategoria")]
        public int? SubCategoriaID { get; set; }
    }
}

