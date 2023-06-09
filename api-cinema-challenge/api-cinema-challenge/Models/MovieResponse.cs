namespace api_cinema_challenge.Models
{
    public class MovieResponse
    {
        public string Status { get; set; } = "Succes";
        public Movie Data { get; set; } // minus the screening
    }
}
