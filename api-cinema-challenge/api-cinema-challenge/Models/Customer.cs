using Microsoft.EntityFrameworkCore.Update.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [DefaultValue("")]
        public string Name { get; set; }

        [DefaultValue("")]
        public string Email { get; set; }
        
        [DefaultValue("")]
        public string Phone { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt { get; set; } // DateTime.UtcNow move this to repository

        [JsonIgnore]
        public DateTime UpdatedAt { get; set; } //{ return _updatedAt; }}

        //private DateTime _updatedAt;

        
        //public void Update()
        //{
        //    _updatedAt = DateTime.UtcNow;
        //}
    }
}
