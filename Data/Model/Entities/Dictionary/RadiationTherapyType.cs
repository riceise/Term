using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор типов лучевой терапии. В НСИ ФФОМС справочник N017 
    /// </summary>
    [Table(name: "RadiationTherapyTypes", Schema = "dict")]
    [Index(nameof(Code))]
    public class RadiationTherapyType : DictionaryBaseType<int>
    {
    }
}
