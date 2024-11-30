using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор типов лечения. В НСИ ФФОМС справочник N013 
    /// </summary>
    [Table(name: "TreatmentTypes", Schema = "dict")]
    [Index(nameof(Code))]
    public class TreatmentType : DictionaryBaseType<int>
    {
    }
}
