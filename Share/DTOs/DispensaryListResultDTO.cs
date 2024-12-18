using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Share.DTOs;

public class DispensaryListResultDTO
{
    public class DispensaryListResult
    {
        public int Id { get; set; }
        
        
        [Display(Name = "Идентификатор списка")]
        public int SpiskiNaDDFromMOId { get; set; }
        
        [Display(Name = "Код МО источник списка")]
        public int SourceMOCode { get; set; }

        [Display(Name = "МО источник списка")]
        public string SourceMOName { get; set; } = string.Empty;
        
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

        [Display(Name = "Период")]
        public int Period { get; set; }                  

        [Display(Name = "Код МО прикрепления")]
        public int? AttachmentMOCode { get; set; }

        [Display(Name = "МО прикрепления")]
        public string AttachmentMOName { get; set; } = string.Empty;

        [Display(Name = "Состоит/не состоит на ДН")]
        public string DispensaryRegistrationStatus { get; set; } = string.Empty;

        [Display(Name = "Код МО, в которой пациент состоит на ДН")]
        public int? RegisteredMOCode { get; set; }

        [Display(Name = "МО, в которой пациент состоит на ДН")]
        public string RegisteredMOName { get; set; } = string.Empty;

        [Display(Name = "Группа ДН")]
        public string DispensaryGroup { get; set; } = string.Empty;
        
        [Display(Name = "Организация")]
        public string Organization { get; set; } = String.Empty; 
        
        [Display(Name = "Результат обработки ТФОМС")]
        public string ProcessingResult { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата прохождения ДН")]
        public DateTime? DateLastDD { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата обработки(Актуальность)")] 
        public DateTime ProcessingDate { get; set; }
    }
}