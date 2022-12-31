using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFeira.Shared
{
    public class Promocao
    {
        public int Id { get; set; }
        [ForeignKey("ProdutoId")]
        public int ProdutoId{get; set;}
        [DataType(DataType.Date)]
        public DateTime Date{get; set;} = DateTime.Now;
        public int Desconto{get; set;} = 0;
    }
}