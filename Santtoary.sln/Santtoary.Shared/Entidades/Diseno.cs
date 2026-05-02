using System.ComponentModel.DataAnnotations;

namespace Santtooary.Shared.Entidades
{
    public class Diseno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título del diseño es obligatorio")]
        public string Titulo { get; set; } = null!;

        public string? ImagenUrl { get; set; }

        [Required(ErrorMessage = "El precio sugerido es obligatorio")]
        public decimal Precio { get; set; }

        public int ArtistaId { get; set; }
        public Artista Artista { get; set; } = null!;
    }
}