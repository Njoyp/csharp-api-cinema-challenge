namespace api_cinema_challenge.Models
{
    public class ScreeningResponse
    {
        public string Status { get; set; } = "Succes";
        public Screening Data { get; set; }
    }
}
