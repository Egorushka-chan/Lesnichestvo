using System.ComponentModel.DataAnnotations;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    public class User : IEntity
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Логин")]
        public string Login { get; set; } = string.Empty;
        [Display(Name = "Пароль")]
        public string Password { get; set; } = string.Empty;
        [Display(Name = "Тип пользователя")]
        public string Type { get; set; } = "Guest";
    }
}
