using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор значений маркёров. В НСИ ФФОМС справочник N011
    /// </summary>
    [Table(name: "CancerMarkerValues", Schema = "dict")]
    [Index(nameof(Code))]
    public class CancerMarkerValue : DictionaryBaseType<int>
    {
        [Display(Name = "Id маркера")]
        public int CancerMarkerId { get; set; }
        public virtual CancerMarker? CancerMarker { get; set; }
        [Display(Name = "Обозначение результата")]
        [MaxLength(250)]
        public string Result { get; set; } = string.Empty;
    }
}
