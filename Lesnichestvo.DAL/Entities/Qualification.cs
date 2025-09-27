using Lesnichestvo.DAL.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Квалификация
    /// </summary>
    public class Qualification : IEntity
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Тип квалификации")]
        public string Type { get; set; } = string.Empty;
        [Display(Name = "Дата выдачи")]
        public DateTime IssueDate { get; set; }
        [Display(Name = "Код сертификата")]
        public string CertificateCode { get; set; } = string.Empty;
        [Display(Name = "Кто выдал")]
        public string IssuedBy { get; set; } = string.Empty;
        [ForeignKey(nameof(Worker))]
        [Display(Name = "ID работника")]
        public int WorkerID { get; set; }

        public Worker? Worker { get; set; }
    }
}
