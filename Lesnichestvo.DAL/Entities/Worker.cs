using Lesnichestvo.DAL.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Работник
    /// </summary>
    public class Worker : IEntity
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string? Patronymic { get; set; }
        public string Role { get; set; } = string.Empty;
        [Required]
        public DateTime IssueDate { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public decimal Payment { get; set; }
        public string? Status { get; set; }
        public List<Qualification> Qualifications { get; set; } = [];
        public List<WorkHasWorkers> Works { get; set; } = [];
    }
}
