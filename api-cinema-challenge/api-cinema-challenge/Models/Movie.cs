using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [DefaultValue("")]
        public string Title { get; set; }

        [DefaultValue("")]
        public string Rating { get; set; }

        [DefaultValue("")]
        public string Description { get; set; }
        public int RuntimeMins { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime CreatedAt { get; set; } // DateTime.UtcNow move this to repository
        
        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime UpdatedAt { get; set; }
    }
}
