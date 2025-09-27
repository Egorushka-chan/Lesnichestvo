using System.ComponentModel.DataAnnotations;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Отчёт
    /// </summary>
    public class Report : IEntity
    {
        public int ID { get; set; }
        [Display(Name = "ID осмотра")]
        public int InspectionID { get; set; }
        [Display(Name = "Тело отчёта")]
        public string Body { get; set; } = string.Empty;
        [Display(Name = "Принятые меры")]
        public string TakenMeasures { get; set; } = string.Empty;
        [Display(Name = "Заключение")]
        public string Conclusion { get; set; } = string.Empty;

        public Inspection? Inspection { get; set; }
    }
}
