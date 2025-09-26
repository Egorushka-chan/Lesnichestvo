using System.ComponentModel.DataAnnotations;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Заказчик
    /// </summary>
    public class Customer : IEntity
    {
        public int ID { get; set; }
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Наименование может быть пустым")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "ИНН")]
        [Required(ErrorMessage = "ИНН не может быть пустым")]
        public string INN { get; set; } = string.Empty;
        [Display(Name = "Тип компании")]
        public string? CompanyType { get; set; }
        [Display(Name = "Дата контракта")]
        public DateTime? ContractDate { get; set; }
        [Display(Name = "Статус")]
        public string? Status { get; set; }

        public List<SoldWood> SoldWoods { get; set; } = [];
    }
}
