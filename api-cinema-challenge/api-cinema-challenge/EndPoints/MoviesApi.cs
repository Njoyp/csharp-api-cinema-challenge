using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class MoviesApi
    {
        public static void ConfigureMoviesApi(this WebApplication app)
        {
            app.MapPost("/Movies", PostMovie);
            app.MapGet("/Movies", GetMovies);
            app.MapPut("/Movies", UpdateMovie);
            app.MapDelete("/Movies/{id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> PostMovie(Movie movie, ICinemaRepository repository)
        {
            try
            {
                var m = repository.AddMovie(movie);
                return m != null ? Results.Created($"https://localhost:7195/Movies/{movie.Id}", m) : Results.BadRequest("Couldn't create new movie, please check all required fields.");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetMovies(ICinemaRepository movie)
        {
            try
            {
                return Results.Ok(movie.GetMovies());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> UpdateMovie(Movie movie, ICinemaRepository repository)
        {
            try
            {
                var m = repository.UpdateMovie(movie);
                return m != null ? Results.Created($"https://localhost:7195/Customers/{movie.Id}", m) : Results.BadRequest("Couldn't update movie, please check all input field.");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteMovie(int id, ICinemaRepository repository)
        {
            try
            {
                var m = repository.DeleteMovie(id);
                return m != null ? Results.Ok(m) : Results.NotFound($"Couldn't find a movie with id: {id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}
