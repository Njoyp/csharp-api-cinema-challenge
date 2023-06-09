using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningsApi
    {
        public static void ConfigureScreeningsApi(this WebApplication app)
        {
            app.MapPost("/Screenings", PostScreening);
            app.MapGet("/Screenings", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> PostScreening(Screening screening,ICinemaRepository repository)
        {
            try
            {
                var s = repository.AddScreening(screening);
                return s != null ? Results.Created($"https://localhost:7195/Screenings/{screening.Id}", s) : Results.BadRequest("Couldn't create new screening, please check all required fields.");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetScreenings(ICinemaRepository screening)
        {
            try
            {
                return Results.Ok(screening.GetScreenings());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
