using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ;

public class Produto
{
    [ForeignKey("IdStand")]
    [ForeignKey("SubCategoria")]
    public int ProdutoId { get; set; }
    public int IdStand { get; set; }
    public float Preco { get; set; }
    public int? Promocao { get; set; }
    public int Stock { get; set; }
    public int? Rating { get; set; }
    public int SubCategoria { get; set; }
}
