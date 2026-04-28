using Microsoft.EntityFrameworkCore;
using Ecommerce.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. SERVICIOS BÁSICOS
builder.Services.AddControllers(); // Habilita el uso de Controladores
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Esto es lo que crea la página visual azul

// 2. CONFIGURACIÓN DE CORS (Obligatorio en tu reto)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// 3. CONFIGURACIÓN DE BASE DE DATOS (PostgreSQL)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// 4. CONFIGURAR EL PIPELINE (Orden de ejecución)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Esto hace que al entrar a /swagger se vea la interfaz
}

app.UseHttpsRedirection();

app.UseCors("AllowFrontend");

app.UseAuthorization();

app.MapControllers(); // Importante: Esto busca las clases en la carpeta Controllers

app.Run();