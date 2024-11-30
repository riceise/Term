using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор гистологических признаков. В НСИ ФФОМС справочник N007
    /// </summary>
    [Table(name: "HistologicalFeatures", Schema = "dict")]
    [Index(nameof(Code))]
    public class HistologicalFeature : DictionaryBaseType<int>
    {
    }
}
