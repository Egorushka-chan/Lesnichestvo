using Lesnichestvo.DAL.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Работа
    /// </summary>
    public class Work : IEntity
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
        [Display(Name = "Потрачено часов")]
        public int HoursSpent { get; set; }
        [ForeignKey(nameof(WorkType))]
        [Display(Name = "Тип работы")]
        public int TypeID { get; set; }
        [ForeignKey(nameof(PreviousWork))]
        [Display(Name = "Предыдущая работа")]
        public int? PreviousWorkID { get; set; }
        
        public WorkType? WorkType { get; set; }
        public Work? PreviousWork { get; set; }
        public List<Inspection> Inspections { get; set; } = [];
        public List<WorkHasInventory> Inventory { get; set; } = [];
        public List<WorkHasWorkers> Workers { get; set; } = [];
    }
}
