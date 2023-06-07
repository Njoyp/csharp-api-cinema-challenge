namespace api_cinema_challenge.EndPoints
{
    public static class MoviesApi
    {
        public static void ConfigureMoviesApi(this WebApplication app)
        {
            app.MapPost("/Movies", PostMovie);
            // get all
            // update
            // delete
        }

        private static async Task<IResult> PostMovie(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
