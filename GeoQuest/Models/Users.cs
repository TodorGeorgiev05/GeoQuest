using System.ComponentModel.DataAnnotations;

namespace GeoQuest.Models
{
    internal class Users
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;

    }
}
