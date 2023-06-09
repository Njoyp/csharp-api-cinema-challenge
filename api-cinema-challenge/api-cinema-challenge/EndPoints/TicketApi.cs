using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketApi
    {
        public static void ConfigureTicketApi(this WebApplication app)
        {
            app.MapPost("/Tickets", PostTicket);
            app.MapGet("/Tickets", GetAllTickets);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> PostTicket(Ticket ticket, ICinemaRepository repository)
        {
            try
            {
                var t = repository.AddTicket(ticket);
                return t != null ? Results.Created($"https://localhost:7195/Tickets/{ticket.Id}", t) : Results.BadRequest("Couldn't create new ticket, please check all required fields.");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    

            [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllTickets(ICinemaRepository ticket)
        {
            try
            {
                return Results.Ok(ticket.GetTickets());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
