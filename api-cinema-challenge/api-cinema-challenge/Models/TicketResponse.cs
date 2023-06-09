namespace api_cinema_challenge.Models
{
    public class TicketResponse
    {
        public string Status { get; set; } = "Succes";
        public Ticket Data { get; set; }
    }
}
