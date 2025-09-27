using System.ComponentModel.DataAnnotations;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Связь N:M Работы и Работников
    /// </summary>
    public class WorkHasWorkers : IEntity
    {
        public int ID { get; set; }
        [Display(Name = "ID работы")]
        public int WorkID { get; set; }
        [Display(Name = "ID работника")]
        public int WorkerID { get; set; }

        public Work? Work { get; set; }
        public Worker? Worker { get; set; }
    }
}
