using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Model.Entities.UploadedFile
{
    public class DispensaryListResult
    {
        [Key]
        [Display(Name = "Идентификатор")]
        public int Id { get; set; }

        [Display(Name = "Идентификатор списка")]
        public int SpiskiNaDnFromMoId { get; set; }

        [ForeignKey("SpiskiNaDNFromMOId")]
        public virtual SpiskiNaDNFromMO SpiskiNaDNFromMO { get; set; }

        [Display(Name = "Код МО источник списка")]
        public int SourceMOCode { get; set; }

        [Display(Name = "МО источник списка")]
        public string SourceMOName { get; set; } = string.Empty;
        
        [Display(Name = "Фамилия")]
        public string LastName { get; set; } = string.Empty;  // From SpiskiNaDNFromMO

        [Display(Name = "Имя")]
        public string Name { get; set; } = string.Empty;        // From SpiskiNaDNFromMO

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; } = string.Empty; // From SpiskiNaDNFromMO

        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }                  // From SpiskiNaDNFromMO

        [Display(Name = "СНИЛС")]
        public string Snils { get; set; } = string.Empty;      // From SpiskiNaDNFromMO

        [Display(Name = "Период")]
        public int Period { get; set; }                      // From SpiskiNaDNFromMO

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
        public string Organization { get; set; } = String.Empty; // From SpiskiNaDNFromMO



        [Display(Name = "Результат обработки ТФОМС")]
        public string ProcessingResult { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата прохождения ДН")]
        public DateTime? DateLastDD { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата обработки(Актуальность)")] // Updated display name
        public DateTime ProcessingDate { get; set; }
    }
}
//SourceMOCode - берется из SpiskiNaDnFromMo (SpiskiNaDnFromMo.N_reest)
//SourceMOName - ищется по SpiskiNaDnFromMo.N_reest в таблице MedicalCompanyDepartment соответствие с Code в таблице MedicalCompany и берется от туда ShortName
//LastName, Name, Patronimic, Snils - проверяется налицие таких людей в таблице Person и после этого заполняется из SpiskiNaDnFromMo
//Period - берется из SpiskiNaDnFromMo(SpiskiNaDnFromMo.Period)
//AttachmentMOCode - 
//AttachmentMOName

