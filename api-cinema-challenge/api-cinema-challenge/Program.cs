using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.EndPoints;
using api_cinema_challenge.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ICinemaRepository, CinemaRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//TODO: change the capitalized strings in the options to match your api and contact details
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Cinema Booking Challenge",
        Description = "This API is part of an assignment and simulates the management of movies in a cinema ",
        Contact = new OpenApiContact
        {
            Name = "Nikita Pieters",
        }
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureTestAPI();
app.ConfigureCustomerApi();
app.ConfigureMoviesApi();
app.ConfigureScreeningsApi();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
