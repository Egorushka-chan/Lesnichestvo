using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Ещё не проданная древесина
    /// </summary>
    public class UnsoldWood : IEntity
    {
        public int ID { get; set; }
        public int WoodTypeID { get; set; }
        public int Quantity { get; set; }
        public int DachaID { get; set; }

        public WoodType? WoodType { get; set; }
        public Dacha? Dacha { get; set; }
    }
}
