using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор поводов обращения. В НСИ ФФОМС справочник N018 
    /// </summary>
    [Table(name: "ReasonAppeals", Schema = "dict")]
    [Index(nameof(Code))]
    public class ReasonAppeal : DictionaryBaseType<int>
    {
    }
}
