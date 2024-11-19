using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Share.DTOs
{
    public class SpiskiNaDNFromMODTO
    {
        [Display(Name = "№ п/п")]
        public int Npp { get; set; }

        [Display(Name = "Фамилия")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Имя")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; } = string.Empty;

        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)] 
        public DateTime BirthDay { get; set; }

        [Display(Name = "СНИЛС")]
        public string Snils { get; set; } = string.Empty;

        [Display(Name = "№ реестра")]
        public int N_reest { get; set; }

        [Display(Name = "Период")]
        public int Period { get; set; }

        [Display(Name = "Организация")]
        public string Organizaciya { get; set; } = string.Empty;
        
    }
}