using System.ComponentModel.DataAnnotations;

namespace Data.Model.Entities.Users
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Поле Имя обязательно для заполнения.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Поле Email обязательно для заполнения.")]
        [EmailAddress(ErrorMessage = "Поле Email указано в неверном формате.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле Пароль обязательно для заполнения.")]
        public string Password { get; set; }
    }
}