using deneme.Application.Interfaces;
using deneme.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddScoped<IRandomNumberService, RandomNumberService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/random", (IRandomNumberService randomNumberService) => 
{
    var randomNumber = randomNumberService.GenerateRandomNumber();
    return Results.Ok(new { number = randomNumber.Value, generatedAt = randomNumber.GeneratedAt });
})
.WithName("GetRandomNumber")
.WithOpenApi()
.Produces(StatusCodes.Status200OK);

app.Run();
