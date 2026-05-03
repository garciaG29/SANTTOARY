using System;
using System.ComponentModel.DataAnnotations;

namespace Santtoary.Shared.Entidades
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        public DateTime Date { get; set; }

        [Range(1, 12, ErrorMessage = "Las horas estimadas deben ser entre 1 y 12")]
        public int EstimatedHours { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public decimal TotalPrice { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio (Ej: Pendiente, Completada)")]
        public string Status { get; set; } = null!;

        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;

        public int ArtistId { get; set; }
        public Artist Artist { get; set; } = null!;
    }
}