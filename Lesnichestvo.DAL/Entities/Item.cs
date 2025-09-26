using Lesnichestvo.DAL.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Предмет инвентаря
    /// </summary>
    [Table("Inventory")]
    public class Item : IEntity
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? Status { get; set; }

        public List<WorkHasInventory> WorksHasItem { get; set; } = [];
    }
}
