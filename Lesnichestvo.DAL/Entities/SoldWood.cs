using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Проданная древесина
    /// </summary>
    public class SoldWood : IEntity
    {
        public int ID { get; set; }
        public int WoodTypeID { get; set; }
        public int Quantity { get; set; }
        public int CustomerID { get; set; }
        public int DachaID { get; set; }
        public WoodType? WoodType { get; set; }
        public Customer? Customer { get; set; }
        public Dacha? Dacha { get; set; }
    }
}
