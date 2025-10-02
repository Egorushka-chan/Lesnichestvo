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
        [Display(Name = "Имя")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Фамилия")]
        public string Surname { get; set; } = string.Empty;
        [Display(Name = "Отчество")]
        public string? Patronymic { get; set; }
        [Display(Name = "Должность")]
        public string Role { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Приём на работу")]
        public DateTime IssueDate { get; set; }
        [Required]
        [Display(Name = "Дата рождения")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Зарплата")]
        [Required(ErrorMessage = "У сотрудника обязательно должна быть зарплата")]
        public decimal Payment { get; set; }
        [Display(Name = "Статус")]
        public string? Status { get; set; }

        public List<Qualification> Qualifications { get; set; } = [];
        public List<WorkHasWorkers> Works { get; set; } = [];
    }
}
