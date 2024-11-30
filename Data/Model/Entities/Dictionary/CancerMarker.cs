using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор маркёров. В НСИ ФФОМС справочник N010
    /// </summary>
    [Table(name: "CancerMarkers", Schema = "dict")]
    [Index(nameof(Code))]
    public class CancerMarker : DictionaryBaseType<int>
    {
        [Display(Name = "Обозначение маркёра")]
        [MaxLength(250)]
        public string ShortName { get; set; } = string.Empty;
    }
}
