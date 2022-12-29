using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Subcategoria
{   
    [Key]
    public int SubCategoriaId { get; set; }
    public string? Descricao { get; set; }
    [ForeignKey("StandId")]
    public int StandId { get; set; }
}