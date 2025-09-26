using Lesnichestvo.DAL.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Сетка координат
    /// </summary>
    public class Mapping : IEntity
    {
        public int ID { get; set; }
        public double XCoord { get; set; }
        public double YCoord { get; set; }
        public int Order {get; set; }
        public string? Description { get; set; }
        [ForeignKey(nameof(QuartalNetwork))]
        public int? NetworkID { get; set; }
        public int? DachaID { get; set; }

        public QuartalNetwork? QuartalNetwork { get; set; }
        public Dacha? Dacha { get; set; }
    }
}
