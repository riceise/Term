using System.ComponentModel.DataAnnotations;
using Data.Model.Entities.Common;
using Data.Model.Entities.Person;

namespace Data.Model.Entities.Invoice
{
    public class ZAP : BaseGUIDEntity
    {
        [Display(Name = "Номер записи")]
        public int ZAPNumber { get; set; }

        [Display(Name = "Id загруженного файла")]
        public Guid UploadFileId { get; set; }

        // [Display(Name = "Ссылка на объект UploadFile")]
        // public virtual UploadFile? UploadFile { get; set; }

        [Display(Name = "Год")]
        public string Year { get; set; } = string.Empty;

        [Display(Name = "Id гражданина из ФЕРЗЛ")]
        public Guid PersonId { get; set; }

        [Display(Name = "Ссылка на объект Person")]
        public virtual Person.Person? Person { get; set; }

        [Display(Name = "Фамилия")]
        public string Surname { get; set; } = string.Empty;
        
        [Display(Name = "Имя")]
        public string Name1 { get; set; } = string.Empty;
        
        [Display(Name = "Отчество")]
        public string Name2 { get; set; } = string.Empty;

        [Display(Name = "Дата рождения")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Номер телефона")]
        public string TelephoneNumber { get; set; } = string.Empty;

        [Display(Name = "СНИЛС")] 
        public string SNILS { get; set; } = string.Empty;

        [Display(Name = "Дата прохождения ДН")] 
        public DateOnly DateDN { get; set; }

        [Display(Name = "Список диспансерных наблюдений")]
        public virtual ICollection<DispensaryObservation> Dispenses { get; } = new List<DispensaryObservation>();

        [Display(Name = "Id реестра счетов")]
        public int InvoiceId { get; set; }
        
        [Display(Name = "Ссылка на объект Invoice")]
        public virtual Invoice? Invoice { get; set; }
    }
}

