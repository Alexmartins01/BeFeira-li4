using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BeFeira.Shared
{
    public class Venda
    {
        public int VendaId {get; set;}
        [ForeignKey("CarrinhoId")]
        public int CarrinhoId{get;set;}
        public float Total { get; set; } = 0f;
        [DataType(DataType.Date)]
        public DateTime Date{get; set;} = DateTime.Now;
    }
}