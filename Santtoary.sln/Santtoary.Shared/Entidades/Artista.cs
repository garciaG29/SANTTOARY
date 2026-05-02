using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Santtooary.Shared.Entidades
{
    public class Artista
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del artista es obligatorio")]
        [MaxLength(100)]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "La especialidad es obligatoria")]
        public string Especialidad { get; set; } = null!;

        [Phone(ErrorMessage = "Formato de teléfono inválido")]
        public string Telefono { get; set; } = null!;

        // Relaciones (Cambiamos Appointment por Cita y Design por Diseno)
        public ICollection<Cita>? Citas { get; set; }
        public ICollection<Diseno>? Disenos { get; set; }
    }
}