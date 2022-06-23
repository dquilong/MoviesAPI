using Movies.api;
using Movies.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<MoviesContext>();
builder.Services.AddScoped<IMoviesRepository, MoviesRepository>();

var app = builder.Build();


// Configure the HTTP request pipeline.
app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
