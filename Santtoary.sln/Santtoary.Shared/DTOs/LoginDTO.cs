using System.ComponentModel.DataAnnotations;

namespace Santtoary.Shared.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "Debes ingresar un correo válido.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public string Password { get; set; } = null!;
    }
}