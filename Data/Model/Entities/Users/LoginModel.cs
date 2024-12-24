using System.ComponentModel.DataAnnotations;

namespace Data.Model.Entities.Users
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Поле Имя обязательно для заполнения.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Поле Пароль обязательно для заполнения.")]
        public string Password { get; set; }
    }
}