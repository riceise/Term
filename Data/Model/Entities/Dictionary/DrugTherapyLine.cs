using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор линий лекарственной терапии. В НСИ ФФОМС справочник N015 
    /// </summary>
    [Table(name: "DrugTherapyLines", Schema = "dict")]
    [Index(nameof(Code))]
    public class DrugTherapyLine : DictionaryBaseType<int>
    {
    }
}
