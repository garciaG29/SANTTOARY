using System.ComponentModel.DataAnnotations;

namespace Santtoary.Shared.Entidades
{
    public class Design
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título del diseño es obligatorio")]
        public string Title { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "El precio sugerido es obligatorio")]
        public decimal Price { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; } = null!;
    }
}