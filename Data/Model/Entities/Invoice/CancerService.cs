using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// Сведения об услуге при лечении онкологического заболевания
    /// </summary>
    [Table(name: "CancerServices", Schema = "zap")]
    public class CancerService : BaseGUIDEntity
    {
        [Display(Name = "Id типа услуги")]
        public int TreatmentTypeId { get; set; }
        public virtual TreatmentType? TreatmentType { get; set; }
        [Display(Name = "Id типа хирургического лечения")]
        public int SurgeryTypeId { get; set; }
        public virtual SurgeryType? SurgeryType { get; set; }
        [Display(Name = "Id линий лекарственной терапии")]
        public int DrugTherapyLineId { get; set; }
        public virtual DrugTherapyLine? DrugTherapyLine { get; set; }
        [Display(Name = "Id цикла лекарственной терапии")]
        public int DrugTherapyCycleId { get; set; }
        public virtual DrugTherapyCycle? DrugTherapyCycle { get; set; }
        [Display(Name = "Признак проведения профилактики тошноты и рвотного рефлекса")]
        public bool IsPreventingNausea { get; set; }

        [Display(Name = "Id типа лучевой терапии")]
        public int RadiationTherapyTypeId { get; set; }
        public virtual RadiationTherapyType? RadiationTherapyType { get; set; }
        [Display(Name = "Id онкологического случая")]
        public Guid CancerCaseId { get; set; }
        public virtual CancerCase? CancerCase { get; set; }
    }
}
