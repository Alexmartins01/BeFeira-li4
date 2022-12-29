using System;

using System.ComponentModel.DataAnnotations.Schema;

namespace BeFeiraBlazor.Models
{
    public class Promocao
    {
        [ForeignKey("ProdutoId")]
        public int ProdutoId{get; set;}
        public DateTime Date{get; set;}
        public int desconto{get; set;}
    }
}