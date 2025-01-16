using Microsoft.EntityFrameworkCore;
using Modelo.API.ExceptionHandler;
using Modelo.API.Persistence;
using Modelo.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IConfigService, ConfigService>();

builder.Services.AddDbContext<ModelDbContext>(o => o.UseInMemoryDatabase("ModelDb"));

//var connectionString = builder.Configuration.GetConnectionString("ModelDB");

//builder.Services.AddDbContext<ModelDbContext>(o => o.UseSqlServer(connectionString));

builder.Services.AddExceptionHandler<ApiExceptionHandler>();
builder.Services.AddProblemDetails();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
