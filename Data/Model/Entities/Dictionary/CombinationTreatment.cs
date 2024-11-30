using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Сочетание схемы лечения и группы препаратов. В НСИ ФФОМС справочник V032
    /// </summary>
    [Table(name: "CombinationTreatments", Schema = "dict")]
    [Index(nameof(Code))]
    public class CombinationTreatment : DictionaryBaseType<string>
    {
        [Display(Name ="Код схемы")]
        [MaxLength(4)]
        public string SchemeCode { get; set; } = string.Empty;
    }
}
