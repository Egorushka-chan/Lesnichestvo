using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Связь N:M Работы и Работников
    /// </summary>
    public class WorkHasWorkers : IEntity
    {
        public int ID { get; set; }
        public int WorkID { get; set; }
        public int WorkerID { get; set; }
        public Work? Work { get; set; }
        public Worker? Worker { get; set; }
    }
}
