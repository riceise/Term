using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор циклов лекарственной терапии. В НСИ ФФОМС справочник N016  
    /// </summary>
    [Table(name: "DrugTherapyCycles", Schema = "dict")]
    [Index(nameof(Code))]
    public class DrugTherapyCycle : DictionaryBaseType<int>
    {
    }
}
