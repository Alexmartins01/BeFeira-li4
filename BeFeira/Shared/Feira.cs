using System.ComponentModel.DataAnnotations.Schema;


namespace BeFeira.Shared
{
    [Table("Feira")]
    public class Feira
	{
		public int ID { get; set; }
		public string Categoria { get; set; } = string.Empty;
	}
}

