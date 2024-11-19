using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Условия оказания мед помощи. В НСИ ФФОМС справочник V006
    /// </summary>
    [Table(name: "UMPs", Schema = "dict")]
	[Index(nameof(Code))]
	public class UMP : DictionaryBaseType<int>
	{
	}
}
