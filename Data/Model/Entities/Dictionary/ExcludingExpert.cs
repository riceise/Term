using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор причин исключения экспертов качества медицинской помощи. В НСИ ФФОМС справочник R010
    /// </summary>
    [Table(name: "ExcludingExperts", Schema = "dict")]
    [Index(nameof(Code))]
    public class ExcludingExpert : DictionaryBaseType<int>
    {
    }
}
