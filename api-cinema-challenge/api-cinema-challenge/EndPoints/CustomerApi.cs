using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            app.MapPost("/Customers", PostCustomer);
            app.MapGet("/Customers", GetCustomers);
            app.MapPut("/Customers", UpdateCustomer);
            app.MapDelete("/Customers/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> PostCustomer(Customer customer, ICinemaRepository repository)
        {
            try
            {
                var c = repository.AddCustomer(customer);
                return c != null ? Results.Created($"https://localhost:7195/Customers/{customer.Id}", c) : Results.BadRequest("Couldn't create new customer, please check all required fields.");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetCustomers(ICinemaRepository customer)
        {
            try
            {
                return Results.Ok(customer.GetCustomers());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> UpdateCustomer(Customer customer, ICinemaRepository repository)
        {
            try
            {
                var c = repository.UpdateCustomer(customer);
                return c != null ? Results.Created($"https://localhost:7195/Customers/{customer.Id}", c) : Results.BadRequest("Couldn't update customer, please check all input field.");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteCustomer(int id, ICinemaRepository repository)
        {
            try
            {
                var c = repository.DeleteCustomer(id);
                return c != null ? Results.Ok(c) : Results.NotFound($"Couldn't find a customer with id: {id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}
