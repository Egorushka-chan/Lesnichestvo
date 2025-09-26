using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Отчёт
    /// </summary>
    public class Report : IEntity
    {
        public int ID { get; set; }
        public int InspectionID { get; set; }
        public string Body { get; set; } = string.Empty;
        public string TakenMeasures { get; set; } = string.Empty;
        public string Conclusion { get; set; } = string.Empty;

        public Inspection? Inspection { get; set; }
    }
}
