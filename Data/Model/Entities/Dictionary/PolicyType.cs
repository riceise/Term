using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор форм изготовления полиса. В НСИ ФФОМС справочник R002
    /// </summary>
    [Table(name: "PolicyTypes", Schema = "dict")]
    [Index(nameof(Code))]
    public class PolicyType : DictionaryBaseType<int>

    {


    }
}
