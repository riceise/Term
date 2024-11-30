using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор противопоказаний и отказов. В НСИ ФФОМС справочник N001
    /// </summary>
    [Table(name: "Contraindications", Schema = "dict")]
    [Index(nameof(Code))]
    public class Contraindication : DictionaryBaseType<int>
    {
    }
}
