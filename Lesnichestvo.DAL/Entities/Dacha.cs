using Lesnichestvo.DAL.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Лесная дача
    /// </summary>
    public class Dacha : IEntity
    {
        public int ID { get; set; }
        [ForeignKey(nameof(QuartalNetwork))]
        public int NetworkID { get; set; }
        public string? Description { get; set; }

        public QuartalNetwork? QuartalNetwork { get; set; }
        public List<Mapping> Mapping { get; set; } = [];
    }
}
