using System;
using System.ComponentModel.DataAnnotations;
using Share.Validations;

namespace Share.DTOs
{
    public class SpiskiNaDDFromMODTO
    {
        public int Id { get; set; }

        public int Npp { get; set; }

        [Required(ErrorMessage = "Фамилия обязательна.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Имя обязательно.")]
        public string Name { get; set; } = string.Empty;

        public string Patronymic { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Дата рождения обязательна.")]
        public DateTime BirthDay { get; set; }

        [Required(ErrorMessage = "СНИЛС обязателен.")]
        [SnilsValidation]
        public string Snils { get; set; } = string.Empty;

        [Required(ErrorMessage = "Номер реестра обязателен.")]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "Номер реестра должен состоять из 6 цифр.")]
        public int N_reest { get; set; }

        public int Period { get; set; }

        public string Organizaciya { get; set; } = string.Empty;
        public int UploadFileInfId { get; set; }

    }
}