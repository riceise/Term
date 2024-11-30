using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// Назначение(направление)
    /// </summary>
    [Table(name: "DispensaryReferrals", Schema = "zap")]
    public class DispensaryReferral : BaseGUIDEntity
    {
        [Display(Name = "Номер по порядку")]
        public int Number {  get; set; } 
        [Display(Name = "Вид направления")]
        public int ReferralType {  get; set; } 
        [Display(Name = "Код медицинского работника")]
        [MaxLength(14)]
        public string DoctorId {  get; set; } = string.Empty;
        [Display(Name = "Id специальности врача")]
        public int MedSpecialId { get; set; }
        public virtual MedSpecial? MedSpecial { get; set; }
        [Display(Name = "Id метода диагностического исследования")]
        public int DiagnosticResearchMethodId { get; set; }
        public virtual DiagnosticMethod? DiagnosticResearchMethod { get; set; }
        [Display(Name = "Id медицинской услуги")]
        public int MedicalServiceId { get; set; }
        public virtual MedicalService? MedicalService { get; set; }
        [Display(Name = "Дата направления")]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Display(Name = "Код МО")]
        public int MedicalCompanyId { get; set; }
        public virtual MedicalCompany.MedicalCompany? MedicalCompany { get; set; }
        [Display(Name = "Id профиля мед помощи")]
        public int MedProfileId { get; set; }
        public virtual MedProfile? MedProfile { get; set; }
        [Display(Name = "Id профиля койки")]
        public int BedMedProfileId { get; set; }
        public virtual BedMedProfile? BedMedProfile { get; set; }
        [Display(Name = "Id случая")]
        public Guid SLCaseId { get; set; }
        public virtual SLCase? SLCase { get; set; }
    }
}
