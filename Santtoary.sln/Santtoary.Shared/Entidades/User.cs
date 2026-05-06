using Microsoft.AspNetCore.Identity;

namespace Santtoary.Shared.Entidades
{
    public class User : IdentityUser
    {
        
        public string Rol { get; set; } = null!;
    }
}