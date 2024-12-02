using System.ComponentModel.DataAnnotations;

namespace Data.Model.Entities.Users
{
    public class RegisterModel
    {
        [Required]
        public string UserName { get; set; } = String.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = String.Empty;

        [Required]
        public string Password { get; set; } = String.Empty;
    }
}