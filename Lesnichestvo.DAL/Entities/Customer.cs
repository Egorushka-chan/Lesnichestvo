using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Заказчик
    /// </summary>
    public class Customer : IEntity
    {
        private string _name = "Новый заказчик";
        private string _inn = "Неизвестный";

        public int ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name {
            get { return _name; }
            set
            {
                if(value != null)
                {
                    _name = value;
                }
            } 
        }
        [Display(Name = "ИНН")]
        public string INN
        {
            get { return _inn; }
            set
            {
                if (value != null)
                {
                    _inn = value;
                }
            }
        }

        [Display(Name = "Тип компании")]
        public string? CompanyType { get; set; }
        [Display(Name = "Дата контракта")]
        public DateTime? ContractDate { get; set; }
        [Display(Name = "Статус")]
        public string? Status { get; set; } = "Активен";

        public List<SoldWood> SoldWoods { get; set; } = [];
    }
}
