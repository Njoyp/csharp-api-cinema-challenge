using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; } // needs to be email<email> instead of string
        public string Phone { get; set; }

        public DateTime CreatedAt = DateTime.UtcNow;
        public DateTime UpdatedAt = DateTime.UtcNow;
    }
}
