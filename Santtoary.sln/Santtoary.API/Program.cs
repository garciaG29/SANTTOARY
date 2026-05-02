using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Santtoary.API.DATA;
using Santtoary.Shared.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Conexion con base de datos SQL Server.

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders(); // Configuración de Identity para autenticación y autorización.

builder.Services.AddScoped<SeedDb>();// Le dice a la aplicación que SeedDb existe y puede ser usado.

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var seed = scope.ServiceProvider.GetRequiredService<SeedDb>();
    await seed.SeedAsync();
} // Ejecuta el Seed al inicio de la aplicación para poblar la base de datos con datos iniciales.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
