using Microsoft.EntityFrameworkCore;
using AutoMapper;
using InventarioApp.Data;
using InventarioApp.Services;
using InventarioApp.DTOs;
using InventarioApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<InventarioContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("InventarioDB")));

builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IProductoService, ProductoService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
