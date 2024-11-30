using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// Сведения о введенном лекарственном препарате
    /// </summary>
    [Table(name: "CancerMedicinalProducts", Schema = "zap")]
    public class CancerMedicinalProduct : BaseGUIDEntity
    {
        [Display(Name = "Id лекарственного препарата")]
        public int MedicationId { get; set; }
        public virtual Medication? Medication { get; set; }

        [Display(Name = "Дата введения лекарственного препарата")]
        public string Date { get; set; } = string.Empty;
        [Display(Name = "Код схемы лекарственной терапии")]
        public int DrugRegimenCodeId { get; set; }
        public virtual ClassificationCriterion? DrugRegimenCode { get; set; }
        [Display(Name = "Id онкологической услуги")]
        public Guid CancerServiceId { get; set; }
        public virtual CancerService? CancerService { get; set; }
    }
}
