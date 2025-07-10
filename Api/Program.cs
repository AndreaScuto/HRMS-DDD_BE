using Domain.Interfaces;
using Repositories.Context;
using Repositories.Implementations;
using Services.Implementations;
using Microsoft.EntityFrameworkCore;
using Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Registra il DbContext
builder.Services.AddDbContext<HmrsDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registra repository e servizi
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

// Controller
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();
app.Run();