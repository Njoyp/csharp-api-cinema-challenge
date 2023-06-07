﻿namespace api_cinema_challenge.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }

        public DateTime CreatedAt { get; set; } // DateTime.UtcNow move this to repository
        public DateTime UpdatedAt { get; set; }
    }
}