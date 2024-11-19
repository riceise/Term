using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// Таблица связка случая и санкций
    /// </summary>
    [Table(name: "SLCaseSanctions", Schema = "zap")]
    public class SLCaseSanction : BaseGUIDEntity
    {
        [Display(Name = "Id случая")]
        public Guid SLCaseId { get; set; }
        public virtual SLCase? SLCase { get; set; }
        [Display(Name = "Id санкции")]
        public Guid SanctionId { get; set; }
        public virtual Sanction? Sanction { get; set; }
    }
    
}
