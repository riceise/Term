using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;
using Data.Model.Entities.Invoice;
using System.ComponentModel.DataAnnotations;

namespace Data.Model
{
    public class DispensaryObservation : BaseEntity
    {
        [Display(Name = "Порядковый номер")]
        public int Number { get; set; }

        [Display(Name = "Id профиля медицинской помощи")]
        public int MedProfileId { get; set; }

        [Display(Name = "Ссылка на объект MedProfileDictionary")]
        public virtual MedProfileDictionary? MedProfileDictionary { get; set; }

        [Display(Name = "Код лечебно-профилактического учреждения")]
        public string LpuType { get; set; } = string.Empty;

        [Display(Name = "Код МКБ")]
        public string DiagnosisCode { get; set; } = string.Empty;
        
        [Display(Name = "Ссылка на объект DiagnosisDictionary")]
        public virtual Diagnosis? Diagnosis { get; set; }
        
        [Display(Name = "Дата начала")]
        public DateTime BeginDate { get; set; }
        
        [Display(Name = "Дата конца")]
        public DateTime EndDate { get; set; }
        
        [Display(Name = "Причина прекращения")]
        public string EndReason { get; set; } = string.Empty;

        [Display(Name = "Id записи")]
        public Guid ZAPId { get; set; }

        [Display(Name = "Ссылка на объект ZAP")]
        public virtual ZAP? ZAP { get; set; }
    }
}

