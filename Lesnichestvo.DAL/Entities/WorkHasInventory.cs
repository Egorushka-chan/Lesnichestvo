using System.ComponentModel.DataAnnotations;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Связь N:M Work и Item
    /// </summary>
    public class WorkHasInventory : IEntity
    {
        public int ID { get; set; }
        [Display(Name = "ID работы")]
        public int WorkID { get; set; }
        [Display(Name = "ID предмета инвентаря")]
        public int ItemID { get; set; }

        public Work? Work { get; set; }
        public Item? Item { get; set; }
    }
}
