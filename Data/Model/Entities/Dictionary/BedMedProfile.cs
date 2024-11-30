using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
using Microsoft.EntityFrameworkCore;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор профилей койки. В НСИ ФФОМС справочник V020
    /// </summary>
    [Table(name: "BedMedProfiles", Schema = "dict")]
    [Index(nameof(Code))]
    public class BedMedProfile:DictionaryBaseType<int>
    {
    }
}
