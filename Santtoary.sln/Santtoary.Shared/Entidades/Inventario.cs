using System.ComponentModel.DataAnnotations;

namespace Santtoary.Shared.Entidades
{
    public class InventoryItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del insumo es obligatorio")]
        public string Name { get; set; } = null!;

        [Range(0, int.MaxValue, ErrorMessage = "La cantidad no puede ser negativa")]
        public int Quantity { get; set; }

        public int MinimumStockLevel { get; set; }
    }
}