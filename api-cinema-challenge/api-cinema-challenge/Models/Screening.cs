using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Screening
    {
        [Key]
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt { get; set; } // DateTime.UtcNow move this to repository
        
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; } 
    }
}
