namespace api_cinema_challenge.Models
{
    public class Screening
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; } // need to be string<datetime> YYYY-MM-DD HH:MM:SS

        public DateTime CreatedAt { get; set; } // DateTime.UtcNow move this to repository
        public DateTime UpdatedAt { get; set; } 
    }
}
