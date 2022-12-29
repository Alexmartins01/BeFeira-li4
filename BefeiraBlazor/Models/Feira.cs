using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ;

public class Feira
{
    [ForeignKey("Categoria")]
    public int FeiraId { get; set; }
    public int Categoria { get; set; }

}
