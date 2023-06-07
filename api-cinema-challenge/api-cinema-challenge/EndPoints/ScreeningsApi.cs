namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningsApi
    {
        public static void ConfigureScreeningsApi(this WebApplication app)
        {
            app.MapPost("/Screenings", PostScreening);
            //get all
        }

        private static async Task<IResult> PostScreening(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
