using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;
using Data.Model.Entities.MedicalCompany;

namespace Data.Model.Entities.Invoice
{
    [Table(name: "USLServices", Schema = "zap")]
    public class USLService: BaseGUIDEntity
    {
        [Display(Name = "Номер записи в реестре услуг")]
        [MaxLength(36)]
        public string IdService { get; set; } = string.Empty;
        [Display(Name = "Подразделение МО")]
        public int MedicalCompanyUnitId { get; set; }
        public virtual MedicalCompanyUnit? MedicalCompanyUnit { get; set; }
        [Display(Name = "Код отделения")]
        public int MedicalCompanyDepartmentId { get; set; }
        public virtual MedicalCompanyDepartment? MedicalCompanyDepartment { get; set; }
        [Display(Name = "Id медицинских услуг")]
        public int MedicalCompanyId { get; set; }
        public virtual MedicalCompany.MedicalCompany? MedicalCompany { get; set; }
        [Display(Name = "Id профиля медицинской помощи")]
        public int MedProfileId { get; set; }
        public virtual MedProfile? MedProfile { get; set; }
        [Display(Name = "Id вида медицинского вмешательства")]
        public int MedicalInterventionTypeId { get; set; }
        public virtual MedicalService? MedicalInterventionType { get; set; }
        [Display(Name = "Id вида медицинского вмешательства(Онкология)")]
        public int VMPMethodId { get; set; }    
        public virtual VMPMethod? VMPMethod { get; set; }

        [Display(Name = "Id услуги")]
        public int MedicalServiceId { get; set; }
        public virtual MedicalService? MedicalService { get; set; }
        [Display(Name = "Признак детского профиля")]
        public bool IsChildrenProfile { get; set; }
        [Display(Name = "Дата начала оказания услуги")]
        [Column(TypeName = "date")]
        public DateTime BeginDate { get; set; }
        [Display(Name = "Дата окончания оказания услуги")]
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Признак отказа")]
        public bool IsRefusal { get; set; }
        [Display(Name = "Диагноз")]
        public int DiagnosisId { get; set; }
        public virtual Diagnosis? Diagnosis { get; set; }
        [Display(Name = "Количество услуг")]
        public decimal NumberServices { get; set; }
        [Display(Name = "Тариф")]
        public decimal Rate { get; set; }
        [Display(Name = "Стоимость медицинской услуги")]
        public decimal TotalSum { get; set; }
        [Display(Name = "Специальность медработника")]
        public int MedSpecialId { get; set; }
        public virtual MedSpecial? MedSpecial { get; set; }
        [Display(Name = "Код медицинского работника")]
        [MaxLength(25)]
        public string DoctorId { get; set; } = string.Empty;
        [Display(Name = "Неполный объем")]
        public int IncompleteVolume { get; set; }
        [Display(Name = "Служебное поле")]
        [MaxLength(250)]
        public string Comments { get; set; } = string.Empty;
        [Display(Name = "Id случая")]
        public Guid SlCaseId { get; set; }
        public virtual SLCase? SlCase { get; set; }

    }
}
