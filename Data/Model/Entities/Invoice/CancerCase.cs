using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// Сведения о случае лечения онкологического заболевания
    /// </summary>
    [Table(name: "CancerCases", Schema = "zap")]
    public class CancerCase : BaseGUIDEntity
    {
        [Display(Name = "Id повода обращения")]
        public int ReasonAppealId { get; set; }
        public virtual ReasonAppeal? ReasonAppeal { get; set; }  
        [Display(Name = "Id стадии заболевания")]
        public int StageId { get; set; }
        public virtual Stage? Stage { get; set; }
        [Display(Name = "Id значения Tumor")]
        public int TumorId { get; set; }
        public virtual Tumor? Tumor { get; set; }
        [Display(Name = "Id значения Nodus")]
        public int NodusId { get; set; }
        public virtual Nodus? Nodus { get; set; }
        [Display(Name = "Id значения Metastasis")]
        public int MetastasisId { get; set; }
        public virtual Metastasis? Metastasis { get; set; }
        [Display(Name = "Признак выявления отдалённых метастазов")]
        public bool IsMetastasis { get; set; }        
        [Display(Name = "Суммарная очаговая доза")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal TotalFocalDose { get; set; }
        [Display(Name = "Количество фракций проведения лучевой терапии")]
        public int FractionsNumber { get; set; }
        [Display(Name = "Масса тела (кг)")]
        [Column(TypeName = "decimal(4,1)")]
        public decimal Weight { get; set; }
        [Display(Name = "Рост (см)")]
        public int Height { get; set; }
        [Display(Name = "Площадь поверхности тела (м2)")]
        [Column(TypeName = "decimal(3,2)")]
        public decimal BodyArea { get; set; }
        [Display(Name = "Id случая")]
        public Guid SLCaseId { get; set; }
        public virtual SLCase? SLCase { get; set; }
    }
}
