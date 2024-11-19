using System;
using System.ComponentModel.DataAnnotations;
using Share.Validations;

namespace Share.DTOs
{
    public class SpiskiNaDNFromMODTO
    {
        [Display(Name = "№ п/п")]
        public int Npp { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Фамилия обязательна.")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Имя обязательно.")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; } = string.Empty;

        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Дата рождения обязательна.")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)] 
        public DateTime BirthDay { get; set; }

        [Display(Name = "СНИЛС")]
        [SnilsValidation] 
        [Required(ErrorMessage = "СНИЛС обязателен.")]
        public string Snils { get; set; } = string.Empty;

        [Display(Name = "№ реестра")]
        [Required(ErrorMessage = "Номер реестра обязателен.")]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "Номер реестра должен состоять из 6 цифр.")]
        public int N_reest { get; set; }

        [Display(Name = "Период")]
        public int Period { get; set; }

        [Display(Name = "Организация")]
        public string Organizaciya { get; set; } = string.Empty;
    }
}