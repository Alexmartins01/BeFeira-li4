using System.ComponentModel.DataAnnotations.Schema;


namespace BeFeira.Shared
{
	public class Feira
	{
		public int FeiraId { get; set; }
		public string Categoria { get; set; } = string.Empty;
	}
}

