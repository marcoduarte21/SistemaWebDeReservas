using GestorDeReservasWeb.BL.Admin;
using GestorDeReservasWeb.BL.Client;
using GestorDeReservasWeb.BL.Employee;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBusinessLogicAdmin, BusinessLogicAdmin>();
builder.Services.AddScoped<IBLClient, BLClient>();
builder.Services.AddScoped<IBLEmployee, BLEmployee>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<GestorDeReservasWeb.DA.DbContexto>(x => x.UseSqlServer(connectionString));

// En el método ConfigureServices del archivo Startup.cs
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("http://localhost:3000"));
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// En el método Configure del archivo Startup.cs
app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
