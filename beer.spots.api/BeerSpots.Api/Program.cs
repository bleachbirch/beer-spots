using BeerSpots.App.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBeerSpotsApp();
builder.Services.AddControllers();

var app = builder.Build();


//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
