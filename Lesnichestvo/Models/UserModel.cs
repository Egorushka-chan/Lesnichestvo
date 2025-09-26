using System.ComponentModel.DataAnnotations;

namespace Lesnichestvo.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Логин не может быть пустым")]
        public string Login { get; set; } = string.Empty;
        [Required(ErrorMessage = "Пароль не может быть пустым")]
        public string Password { get; set; } = string.Empty;
    }
}
