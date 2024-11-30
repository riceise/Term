using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор результатов гистологических исследований. В НСИ ФФОМС справочник N008
    /// </summary>
    [Table(name: "HistologicalExaminationResults", Schema = "dict")]
    [Index(nameof(Code))]
    public class HistologicalExaminationResult : DictionaryBaseType<int>
    {
        [Display(Name = "Id гистологического признака")]
        public int HistologicalFeatureId { get; set; }  
        public virtual HistologicalFeature? HistologicalFeature { get; set; }
    }
}
