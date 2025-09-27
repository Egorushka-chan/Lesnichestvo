using Lesnichestvo.DAL.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Лесная дача
    /// </summary>
    public class Dacha : IEntity
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey(nameof(QuartalNetwork))]
        [Display(Name = "ID квартальной сети")]
        public int NetworkID { get; set; }
        [Display(Name = "Описание")]
        public string? Description { get; set; }

        public QuartalNetwork? QuartalNetwork { get; set; }
        public List<Mapping> Mapping { get; set; } = [];
    }
}
