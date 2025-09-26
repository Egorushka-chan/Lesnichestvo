using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Связь N:M Work и Item
    /// </summary>
    public class WorkHasInventory : IEntity
    {
        public int ID { get; set; }
        public int WorkID { get; set; }
        public int ItemID { get; set; }

        public Work? Work { get; set; }
        public Item? Item { get; set; }
    }
}
