using System;
using System.ComponentModel.DataAnnotations;

namespace Santtooary.Shared.Entidades
{
    public class Cita
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        public DateTime Fecha { get; set; }

        [Range(1, 12, ErrorMessage = "Las horas estimadas deben ser entre 1 y 12")]
        public int HorasEstimadas { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public decimal PrecioTotal { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio (Ej: Pendiente, Completada)")]
        public string Estado { get; set; } = null!;

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

        public int ArtistaId { get; set; }
        public Artista Artista { get; set; } = null!;
    }
}
