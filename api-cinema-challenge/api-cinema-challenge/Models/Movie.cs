using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        public DateTime CreatedAt { get; set; } // DateTime.UtcNow move this to repository
        
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; }

        
       
        public IEnumerable<Screening> MovieScreenings { get; set; } // but without the id?
        
    }
}
