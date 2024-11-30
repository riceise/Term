using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор клинико-профильных групп. В НСИ ФФОМС справочник V026
    /// </summary>
    [Table(name: "KPGs", Schema = "dict")]
    [Index(nameof(Code))]
    public class KPG : DictionaryBaseType<string>
    {
        [Display(Name = "Коэффициент затратоемкости КПГ")]
        public decimal Coefficient { get; set; }
        [Display(Name = "Id условия оказания")]
        public int UMPId { get; set; }
        public virtual UMP? UMP { get; set; }
    }

}
