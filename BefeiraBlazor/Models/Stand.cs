using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Stand 
{   
    [Key]
    public int StandId { get; set; }
    [ForeignKey("VendedorId")]
    public int VendedorId { get; set; }
    [ForeignKey("FeiraId")]
    public int FeiraId { get; set; }
}