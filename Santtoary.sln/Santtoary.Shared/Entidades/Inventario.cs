using System.ComponentModel.DataAnnotations;

namespace Santtooary.Shared.Entidades
{
    public class Inventario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del insumo es obligatorio")]
        public string Nombre { get; set; } = null!;

        [Range(0, int.MaxValue, ErrorMessage = "La cantidad no puede ser negativa")]
        public int Cantidad { get; set; }

        public int NivelStockMinimo { get; set; }
    }
}