using System.ComponentModel.DataAnnotations.Schema;


namespace BeFeira.Models;
public class Feira
{
    [ForeignKey("Categoria")]
    public int FeiraId { get; set; }
    public int Categoria { get; set; }
}
