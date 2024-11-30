using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор лекарственных препаратов, применяемых при проведении лекарственной терапии. В НСИ ФФОМС справочник N020
    /// </summary>
    [Table(name: "Medications", Schema = "dict")]
    [Index(nameof(Code))]
    public class Medication : DictionaryBaseType<string>
    {
    }
}
