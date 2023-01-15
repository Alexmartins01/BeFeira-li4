using System.ComponentModel.DataAnnotations.Schema;

namespace BeFeira.Shared
{
    [Table("Cliente")]
    public class Cliente
    {
        public int ID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public float Total { get; set; } = 0;

        public string? UrlProfilePic { get; set; } = "https://cdn-icons-png.flaticon.com/512/5087/5087579.png";


    }
}


