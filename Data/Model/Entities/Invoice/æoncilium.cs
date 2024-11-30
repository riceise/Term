using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// Сведения о проведении консилиума
    /// </summary>
    [Table(name: "Сonciliums", Schema = "zap")]
    public class Сoncilium : BaseGUIDEntity
    {
        [Display(Name = "Id цели проведения консилиума")]
        public int ConsultationPurposeId { get; set; }
        public virtual ConsultationPurpose? ConsultationPurpose { get; set; }
        [Display(Name = "Дата направления")]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Display(Name = "Id случая")]
        public Guid SLCaseId { get; set; }
        public virtual SLCase? SLCase { get; set; }
    }
}
