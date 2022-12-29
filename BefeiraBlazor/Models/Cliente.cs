using System;

using System.ComponentModel.DataAnnotations;

namespace ;

public class Cliente
{
    public int ClienteId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string? Email { get; set; }
}
