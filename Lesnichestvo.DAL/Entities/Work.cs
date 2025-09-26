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
        public DateTime Date { get; set; }
        public int HoursSpent { get; set; }
        [ForeignKey(nameof(WorkType))]
        public int TypeID { get; set; }
        [ForeignKey(nameof(PreviousWork))]
        public int? PreviousWorkID { get; set; }
        
        public WorkType? WorkType { get; set; }
        public Work? PreviousWork { get; set; }
        public List<Inspection> Inspections { get; set; } = [];
        public List<WorkHasInventory> Inventory { get; set; } = [];
        public List<WorkHasWorkers> Workers { get; set; } = [];
    }
}
