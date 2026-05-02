using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Santtoary.Shared.Entidades
{
    public class Client
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "El documento es obligatorio")]
        public string Document { get; set; } = null!;

        public string? Phone { get; set; }

        [EmailAddress(ErrorMessage = "Email inválido")]
        public string? Email { get; set; }

        public string? MedicalNotes { get; set; }

        public ICollection<Appointment>? Appointments { get; set; }
    }
}