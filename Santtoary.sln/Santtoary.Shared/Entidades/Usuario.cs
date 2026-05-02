using Microsoft.AspNetCore.Identity;

namespace Santtooary.Shared.Entidades
{
    public class Usuario : IdentityUser
    {
        // Rol puede ser 'Administrador' o 'Usuario'
        public string Rol { get; set; } = null!;
    }
}