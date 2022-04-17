using BeerSpots.App.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

var dbConfig = builder.Configuration.GetSection("BeerSpotsDb");
builder.Services.AddBeerSpotsApp(dbConfig);
builder.Services.AddControllers();

var app = builder.Build();


//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
