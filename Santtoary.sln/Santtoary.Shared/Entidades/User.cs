using Microsoft.AspNetCore.Identity;

namespace Santtoary.Shared.Entidades
{
    public class User : IdentityUser
    {
        // Tu amigo dejó esta propiedad en español en su SeedDb ("Rol" = "Admin")
        public string Rol { get; set; } = null!;
    }
}