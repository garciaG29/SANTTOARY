using Microsoft.AspNetCore.Identity;

namespace Santtoary.Shared.Entidades
{
    public class User : IdentityUser // Hereda de IdentityUser para incluir propiedades de autenticación y autorización
    {
        // Rol puede ser 'Administrador' o 'Usuario'
        public string Rol { get; set; } = null!;
    }
}