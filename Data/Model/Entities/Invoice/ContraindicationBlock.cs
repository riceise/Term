using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// Сведения об имеющихся противопоказаниях и отказах
    /// </summary>
    [Table(name: "ContraindicationBlocks", Schema = "zap")]
    public class ContraindicationBlock : BaseGUIDEntity
    {
        [Display(Name = "Id противопоказания и отказа")]
        public int ContraindicationId { get; set; }
        public virtual Contraindication? Contraindication { get; set; }
        [Display(Name = "Дата регистрации противопоказания или отказа")]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Display(Name = "Id онкологического случая")]
        public Guid CancerCaseId { get; set; }
        public virtual CancerCase? CancerCase { get; set; }
    }
}
