using System;

using System.ComponentModel.DataAnnotations.Schema;


namespace BeFeiraBlazor.Models
{
    public class Venda
    {
        public int VendaId {get; set;}
        [ForeignKey("CarrinhoId")]
        public int CarrinhoId{get;set;}
        public float Total{get; set;}
        public DateTime Date{get; set;}
    }
}