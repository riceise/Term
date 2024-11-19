using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// Коэфициент сложности
    /// </summary>
    [Table(name: "DifficultyCoefficients", Schema = "zap")]
    public class DifficultyCoefficient : BaseGUIDEntity
    {
        [Display(Name ="КСЛП id")]
        public int KSLPId {  get; set; }
        public virtual KSLP? KSLP { get; set; }
        [Display(Name = "Значение коэффициента сложности лечения пациента")]
        [Column(TypeName = "decimal(18,5)")]
        public decimal Value { get; set; }
        [Display(Name ="КСГ/КПГ Id")]
        public Guid KSGKPGId { get; set; }
        public virtual KSGKPG? KSGKPG { get; set; }
    }
}
