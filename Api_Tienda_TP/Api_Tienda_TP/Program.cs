using Microsoft.EntityFrameworkCore;
using ProyectoCompartido;
using Api_Tienda_TP.Datos;
using Api_Tienda_TP.Negocio;
using Api_Tienda_TP.Negocio.Interfaz;
using Api_Tienda_TP.Negocio.Implementacion;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<TiendaDbContext>(options => options.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString)));

// Add services to the container.
builder.Services.AddControllers();

// Opcional: Configurar JSON para evitar ciclos de referencia
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});

builder.Services.AddScoped<IBL_Cliente, BL_Cliente>();
builder.Services.AddScoped<IBL_Producto, BL_Producto>();
builder.Services.AddScoped<IBL_ProductoAPilas, BL_ProductoAPilas>();
builder.Services.AddScoped<IBL_ProductoElectronico, BL_ProductoElectronico>();
builder.Services.AddScoped<IBL_Venta, BL_Venta>();
builder.Services.AddScoped<IBL_Proveedor, BL_Proveedor>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();