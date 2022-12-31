using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFeira.Shared
{
    public class Stand
    {
        [Key]
        public int StandId { get; set; }

        [ForeignKey("VendedorId")]
        public int VendedorId { get; set; }

        [ForeignKey("FeiraId")]
        public int FeiraId { get; set; }
    }
}