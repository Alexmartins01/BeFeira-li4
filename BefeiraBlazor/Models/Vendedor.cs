using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Vendedor
{   
    [Key]
    public int VendedorId { get; set; }
    public string Iban { get; set; }
    public string Mbway { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int? Rating { get; set; }
    public string Email { get; set; } 
}