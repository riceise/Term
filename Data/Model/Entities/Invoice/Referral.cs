using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;

//using Telerik.SvgIcons;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// Сведения об оформлении направления 
    /// </summary>
    [Table(name: "Referrals", Schema = "zap")]
    public class Referral : BaseGUIDEntity
    {
        [Display(Name ="Дата направления")]
        [Column(TypeName = "date")]
        public DateTime Date {  get; set; }
        [Display(Name="Код МО")]
        public int MedicalCompanyId { get; set; }
        public virtual MedicalCompany.MedicalCompany? MedicalCompany { get; set; }
        [Display(Name ="Id вида направления")]
        public int DirectionTypeId { get; set; }
        public virtual DirectionType? DirectionType { get; set; }
        [Display(Name ="Id метода диагностического исследования")]
        public int DiagnosticResearchMethodId { get; set; }
        public virtual DiagnosticMethod? DiagnosticResearchMethod { get; set; }
        [Display(Name ="Id медицинской услуги")]
        public int MedicalServiceId { get; set; }
        public virtual MedicalService? MedicalService { get; set; }
        [Display(Name = "Id случая")]
        public Guid SLCaseId { get; set; }
        public virtual SLCase? SLCase { get; set; }
    }
}
