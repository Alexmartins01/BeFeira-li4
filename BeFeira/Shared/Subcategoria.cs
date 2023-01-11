using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeFeira.Shared
{
    [Table("Subcategoria")]
    public class Subcategoria
    {
        public int ID { get; set; }
        public string Descricao { get; set; } = string.Empty;

        [ForeignKey("Stand")]
        public int? StandID { get; set; }
        public virtual Stand? Stand { get; set; }
    }
}