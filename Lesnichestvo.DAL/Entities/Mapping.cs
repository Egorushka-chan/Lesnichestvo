using Lesnichestvo.DAL.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Сетка координат
    /// </summary>
    public class Mapping : IEntity
    {
        public int ID { get; set; }
        [Display(Name = "X")]
        public double XCoord { get; set; }
        [Display(Name = "Y")]
        public double YCoord { get; set; }
        [Display(Name = "Порядок")]
        public int Order {get; set; }
        [Display(Name = "Описание")]
        public string? Description { get; set; }
        [ForeignKey(nameof(QuartalNetwork))]
        [Display(Name = "ID квартальной сети")]
        public int? NetworkID { get; set; }
        [Display(Name = "ID лесной дачи")]
        public int? DachaID { get; set; }

        public QuartalNetwork? QuartalNetwork { get; set; }
        public Dacha? Dacha { get; set; }
    }
}
