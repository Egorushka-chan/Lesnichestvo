using System.ComponentModel.DataAnnotations;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Проданная древесина
    /// </summary>
    public class SoldWood : IEntity
    {
        public int ID { get; set; }
        [Display(Name = "ID типа древесины")]
        public int WoodTypeID { get; set; }
        [Display(Name = "Количество")]
        public int Quantity { get; set; }
        [Display(Name = "ID заказчика")]
        public int CustomerID { get; set; }
        [Display(Name = "ID лесной дачи")]
        public int DachaID { get; set; }

        public WoodType? WoodType { get; set; }
        public Customer? Customer { get; set; }
        public Dacha? Dacha { get; set; }
    }
}
