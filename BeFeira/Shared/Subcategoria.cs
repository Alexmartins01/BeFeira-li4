using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeFeira.Shared
{
    public class Subcategoria
    {
        [Key]
        public int SubCategoriaId { get; set; }
        public string Descricao { get; set; } = string.Empty;
        [ForeignKey("StandId")]
        public int StandId { get; set; }
    }
}