using BeerSpots.App.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

var dbConfig = builder.Configuration.GetSection("BeerSpotsDb");
builder.Services.AddBeerSpotsApp(dbConfig);
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
