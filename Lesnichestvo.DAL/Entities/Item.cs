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
        [Display(Name = "Название")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Цена")]
        public decimal Price { get; set; }
        [Display(Name = "Статус")]
        public string? Status { get; set; }

        public List<WorkHasInventory> WorksHasItem { get; set; } = [];
    }
}
