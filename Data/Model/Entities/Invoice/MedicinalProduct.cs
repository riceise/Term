using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// Сведения о введенном лекарственном препарате
    /// </summary>
    [Table(name: "MedicinalProducts", Schema = "zap")]
    public class MedicinalProduct : BaseGUIDEntity
    {
        [Display(Name = "Дата введения лекарственного препарата")]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Display(Name = "Id схемы лечения пациента/код группы препарата")]
        public int CombinationTreatmentId { get; set; }
        public virtual CombinationTreatment? CombinationTreatment { get; set; }
        [Display(Name = "Id лекарственного препарата")]
        public int MedicationId { get; set; }
        public virtual Medication? Medication { get; set; }   
        [Display(Name = "Код маркировки лекарственного препарата")]
        [MaxLength(100)]
        public string LabelCode { get; set; } = string.Empty;
        /// <summary>
        /// Сведения о дозе введения лекарственного препарата
        /// </summary>
        [Display(Name = "Id Единицы измерения дозы лекарственного препарата")]
        public int UnitId { get; set; }
        public virtual Unit? Unit { get; set; }
        [Display(Name = "Доза введения лекарственного препарата")]
        [Column(TypeName = "decimal(7,2)")]
        public decimal UnitValue { get; set; }
        [Display(Name = "Id пути введения лекарственного препарата")]
        public int InjectionMethodId { get; set; }
        public virtual InjectionMethod? InjectionMethod { get; set; }
        [Display(Name = "Количество введений")]
        public int InjectionsNumber {  get; set; }
        [Display(Name = "Id случая")]
        public Guid SLCaseId { get; set; }
        public virtual SLCase? SLCase { get; set; }
    }
}
