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
        public int SpiskiNaDDFromMOId { get; set; }

        [ForeignKey("SpiskiNaDDFromMOId")]
        public virtual SpiskiNaDDFromMO? SpiskiNaDDFromMO { get; set; }

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
        public int AttachmentMOCode { get; set; }

        [Display(Name = "МО прикрепления")]
        public string AttachmentMOName { get; set; } = string.Empty;

        // [Display(Name = "Состоит/не состоит на ДН")]
        // public string DispensaryRegistrationStatus { get; set; } = string.Empty;

        // [Display(Name = "Код МО, в которой пациент состоит на ДН")]
        // public int? RegisteredMOCode { get; set; }

        // [Display(Name = "МО, в которой пациент состоит на ДН")]
        // public string RegisteredMOName { get; set; } = string.Empty;

        // [Display(Name = "Группа ДН")]
        // public string DispensaryGroup { get; set; } = string.Empty;

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
        [Display(Name = "Дата обработки(Актуальность)")] // Updated display name
        public DateTime ProcessingDate { get; set; }
    }
}
//SourceMOCode - берется из SpiskiNaDDFromMO (SpiskiNaDDFromMO.N_reest)
//SourceMOName - ищется по SpiskiNaDDFromMO.N_reest в таблице MedicalCompany соответствие с Code в таблице MedicalCompany и берется от туда ShortName
//LastName, Name, Patronimic, Snils - заполняется из SpiskiNaDDFromMO
//Period - берется из SpiskiNaDDFromMO(SpiskiNaDDFromMO.Period)
//AttachmentMOCode - берется из DispensaryObservation (DispensaryObservation.LpuType)
//AttachmentMOName - берется из MedicalCompany.ShortName по MedicalCompany.Code такой же как и DispensaryObservation.LpuType
//DispensaryRegistrationStatus - если есть запись в ZAP о таком человеке то "Не состоит на ДН"  если есть запись в zap с таким человеком то "Состоит на ДН"
//RegisteredMOCode - берется из DispensaryObservation (DispensaryObservation.LpuType) если человек не состоит на дн то поле остаётся пустым 
//RegisteredMOName - берется из MedicalCompany.ShortName по MedicalCompany.Code такой же как и DispensaryObservation.LpuType если человек не состоит на дн то поле остаётся пустым 
//DispensaryGroup - берется из DispensaryObservation.DiagnosisCode в ZAP есть ICollection<DispensaryObservation> Dispenses которрый ссылается на DispensaryObservation если человек не состоит на дн то поле остаётся пустым 
//Organization - берется из SpiskiNaDDFromMO.Organizaciya
//ProcessingResult - если человек проходил в этом году то ставится "Ок. Проведена ДДвзр в текущем году" иначе "Нет первого ДД и ПМО в текущем году" это проверяется по дате EndDate
//DateLastDD - если человек не состоит на дн то поле остаётся пустым иначе ставится иначе берется дата берется из ZAP.DateDN 
//ProcessingDate - дата обработки файла  

