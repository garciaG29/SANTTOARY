using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Santtoary.Shared.Entidades;


namespace Santtoary.API.DATA
{
    public class SeedDb
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public SeedDb(ApplicationDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task SeedAsync()
        {
            await _context.Database.MigrateAsync(); // Aplica las migraciones pendientes a la base de datos.
            //Roles
            if (!await _roleManager.RoleExistsAsync("Admin"))
                await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
            if (!await _roleManager.RoleExistsAsync("Artista"))
                await _roleManager.CreateAsync(new IdentityRole { Name = "Artista" });
            if (!await _roleManager.RoleExistsAsync("Cliente"))
                await _roleManager.CreateAsync(new IdentityRole { Name = "Cliente" });
            //Usuario Administrador
            if (await _userManager.FindByEmailAsync("Admin@Santtoary.com") == null) // Verifica si no hay usuarios en la base de datos.
            {
                var admin = new User // Crea un nuevo usuario administrador.
                {
                    UserName = "admin@Santtoary.com",
                    Email = "admin@Santtoary.com",
                    Rol = "Admin"
                };
                await _userManager.CreateAsync(admin, "Admin123!"); // Crea el usuario con una contraseña segura.
                await _userManager.AddToRoleAsync(admin, "Admin"); // Asigna el rol de administrador al usuario creado.

            }
            //Usuario Artista Inicial
            if (!await _context.Artists.AnyAsync()) // Verifica si no hay artistas en la base de datos.
            {
                _context.Artists.AddRange(
                  new Artist { Name = "Pablo Chacon", Specialty = "Realismo", PhoneNumber = "3029634561" },
                  new Artist { Name = "Laura Aristizabal", Specialty = "Minimalista", PhoneNumber = "3019855474" },
                  new Artist { Name = "Cuto Ramirez", Specialty = "Tribal", PhoneNumber = "3017531594" }
                );
                await _context.SaveChangesAsync(); // Guarda los cambios en la base de datos.
            }
            //Usuario Cliente Inicial
            if (!await _context.Clients.AnyAsync()) // Verifica si no hay clientes en
            {
                _context.Clients.AddRange(
                  new Client { Name = "Juan Perez", Phone = "3017853651", Email = "JuanP@email.com", MedicalNotes = "Ninguna", Document = "123456789" },
                  new Client { Name = "Maria Gomez", Phone = "3016547892", Email = "MariaG@email.com", MedicalNotes = "Alergica a anestesia", Document = "987654321" }
                  );
                await _context.SaveChangesAsync(); // Guarda los cambios en la base de datos.
            }
        }
    }
}