using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Services.Profiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",

            builder =>
            {
                builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
            });
});


//Povezivanje sa PostgreSQL bazom
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql("Host=weather-postgres;Port=5432;Database=weatherdb;Username=postgres;Password=postgres"));

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<WeatherForecastProfile>();
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
