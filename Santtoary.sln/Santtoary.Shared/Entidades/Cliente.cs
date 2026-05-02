using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Santtooary.Shared.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100)]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El documento es obligatorio")]
        public string Documento { get; set; } = null!;

        public string? Telefono { get; set; }

        [EmailAddress(ErrorMessage = "Email inválido")]
        public string? Email { get; set; }

        public string? NotasMedicas { get; set; }

        public ICollection<Cita>? Citas { get; set; }
    }
}