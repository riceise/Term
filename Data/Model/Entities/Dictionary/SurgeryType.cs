using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор типов хирургического лечения . В НСИ ФФОМС справочник N014 
    /// </summary>
    [Table(name: "SurgeryTypes", Schema = "dict")]
    [Index(nameof(Code))]
    public class SurgeryType : DictionaryBaseType<int>
    {
    }
}
