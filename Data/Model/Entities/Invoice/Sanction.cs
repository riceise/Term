using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Data.Model.Entities.Dictionary;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// Сведения об санкциях
    /// </summary>
    [Table(name: "Sanctions", Schema = "zap")]
    public class Sanction : BaseGUIDEntity
    {
        [Display(Name = "Идентификатор санкции")]
        [MaxLength(36)]
        public string SanctionId { get; set; } = string.Empty;
        [Display(Name = "Сумма финансовой санкции")]
        public decimal TotalSum { get; set; }
        [Display(Name = "Id вида контроля")]
        public int ControlTypeId { get; set; }
        public virtual ControlType? ControlType { get; set; }
        [Display(Name = "Id причины отказа (частичной) оплаты")]
        public int RefusalReasonId { get; set; }
        public virtual RefusalReason? RefusalReason { get; set; }
        [Display(Name = "Дата акта")]
        [Column(TypeName = "date")]
        public DateTime ActDate { get; set; }
        [Display(Name = "Номер акта")]
        [MaxLength(30)]
        public string ActNumber { get; set; } = string.Empty;
        [Display(Name = "Комментарий")]
        [MaxLength(2500)]
        public string Comments { get; set; } = string.Empty;
        [Display(Name = "Источник")]
        public bool Source {  get; set; }
        [Display(Name ="Id законченного случая")]
        public Guid ZAPMainRecordId { get; set; }
        public virtual ZAPMainRecord? ZAPMainRecord { get; set; }
        [Display(Name = "Эксперты")]
        public virtual List<ExpertReestr>? Experts { get; set; } 
        [Display(Name = "Случаи")]
        public virtual List<SLCase>? SLCases { get; set; }

    }
    
}
