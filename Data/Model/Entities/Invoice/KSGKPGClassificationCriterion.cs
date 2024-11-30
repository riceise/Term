using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;

namespace Data.Model.Entities.Invoice
{
    [Table(name: "KSGKPGClassificationCriterions", Schema = "zap")]
    public class KSGKPGClassificationCriterion : BaseGUIDEntity
    {
        [Display(Name ="Id КСГ/КПГ")]
        public Guid KSGKPGId { get; set; }
        public virtual KSGKPG? KSGKPG { get; set; }
        [Display(Name = "Id классификационного критерия")]
        public int ClassificationCriterionId { get; set; }  
        public virtual ClassificationCriterion? ClassificationCriterion { get; set; }

    }
}
