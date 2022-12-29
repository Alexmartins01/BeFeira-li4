using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BeFeira.Models
{
    public class Venda
    {
        public int VendaId {get; set;}
        [ForeignKey("CarrinhoId")]
        public int CarrinhoId{get;set;}
        public float Total{get; set;}
        [DataType(DataType.Date)]
        public DateTime Date{get; set;}
    }
}