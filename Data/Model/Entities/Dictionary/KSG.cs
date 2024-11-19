using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор клинико-статистических групп. В НСИ ФФОМС справочник V023
    /// </summary>
    [Table(name: "KSGs", Schema = "dict")]
    [Index(nameof(Code))]
    public class KSG : DictionaryBaseType<string>
    {
        [Display(Name = "Коэффициент затратоемкости КСГ")]
        public decimal Coefficient { get; set; }
        [Display(Name = "Id условия оказания")]
        public int UMPId { get; set; }
        public virtual UMP? UMP { get; set; }
    }

}
