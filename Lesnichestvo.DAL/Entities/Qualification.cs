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
        public string Type { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public string CertificateCode { get; set; } = string.Empty;
        public string IssuedBy { get; set; } = string.Empty;
        [ForeignKey(nameof(Worker))]
        public int WorkerID { get; set; }
        public Worker? Worker { get; set; }
    }
}
