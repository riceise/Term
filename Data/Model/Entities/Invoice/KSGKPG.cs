using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// КСГ\КПГ
    /// </summary>
    [Table(name: "KSGKPGs", Schema = "zap")]
    public class KSGKPG : BaseGUIDEntity
    {
        [Display(Name = "Id КСГ")]
        public int KSGId { get; set; }
        public virtual KSG? KSG { get; set; }
        [Display(Name = "Модель определения КСГ")]
        public int KSGModel {  get; set; }
        [Display(Name = "Признак использования подгруппы КСГ")]
        public bool IsSubgroupKSG { get; set; }
        [Display(Name = "Id КПГ")]
        public int KPGId { get; set; }
        public virtual KPG? KPG { get; set; }
        
        [Display(Name = "Коэффициент затратоемкости")]
        [Column(TypeName = "decimal(7,5)")]
        public decimal CostCoefficient { get; set; }
        [Display(Name = "Управленческий коэффициент")]
        [Column(TypeName = "decimal(7,5)")]
        public decimal ManagementCoefficient { get; set; }
        [Display(Name = "Базовая ставка")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal BaseRate { get; set; }
        [Display(Name = "Коэффициент дифференциации")]
        [Column(TypeName = "decimal(7,5)")]
        public decimal DifferentiationCoefficient {  get; set; }
        [Display(Name = "Коэффициент уровня/подуровня оказания медицинской помощи")]
        [Column(TypeName = "decimal(7,5)")]
        public decimal LevelCoefficient { get; set; }
        [Display(Name = "Признак использования КСЛП")]
        public bool IsKSLP { get; set; }
        [Display(Name = "Применённый коэффициент сложности лечения пациента")]
        [Column(TypeName = "decimal(6,5)")]
        public decimal DifficultyCoefficient { get; set; }
        [Display(Name = "Id случая")]
        public Guid SlCaseId { get; set; }
        public virtual SLCase? SlCase { get; set; }
        public virtual List<ClassificationCriterion>? ClassificationCriterions { get; set; }
            
    }
}
