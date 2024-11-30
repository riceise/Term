using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор целей консилиума. В НСИ ФФОМС справочник N019
    /// </summary>
    [Table(name: "ConsultationPurposes", Schema = "dict")]
    [Index(nameof(Code))]
    public class ConsultationPurpose : DictionaryBaseType<int>
    {
    }
}
