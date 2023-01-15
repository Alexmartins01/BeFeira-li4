using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BeFeira.Shared
{
    [Table("Venda")]
    public class Venda
    {
        public int ID { get; set; }
        [ForeignKey("Carrinho")]
        public int? CarrinhoID { get; set; }
        public virtual Carrinho? Carrinho { get; set; }
        public float Total { get; set; } = 0f;
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now;

        public string Morada { get; set; } = "";

        public int Pagamento { get; set; }=0;


    }
}