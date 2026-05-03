using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Santtoary.Shared.Entidades
{
    public class Artist
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del artista es obligatorio")]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "La especialidad es obligatoria")]
        public string Specialty { get; set; } = null!;

        [Phone(ErrorMessage = "Formato de teléfono inválido")]
        public string PhoneNumber { get; set; } = null!;

        // Relaciones
        public ICollection<Appointment>? Appointments { get; set; }
        public ICollection<Design>? Designs { get; set; }
    }
}