using System.ComponentModel.DataAnnotations;

namespace Data.Model.Entities.Users
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}