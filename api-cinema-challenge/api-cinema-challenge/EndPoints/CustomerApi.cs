namespace api_cinema_challenge.EndPoints
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            app.MapPost("/Customers", PostCustomer);
            // get all
            // update
            // delete
        }

        private static async Task<IResult> PostCustomer(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
