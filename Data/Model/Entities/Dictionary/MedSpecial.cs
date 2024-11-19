using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model.Entities.Common;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор медицинских спецальностей(должностей). В НСИ ФФОМС справочник V021
    /// </summary>
    [Table(name: "MedSpecials", Schema = "dict")]
    [Index(nameof(Code))]
    public class MedSpecial:DictionaryBaseType<int>
    {
        [Display(Name = "Наименование специальности")]
        public string NameSpec { get; set; } = string.Empty;
        [Display(Name = "Код должности в соответствии с НСИ Минздрава России")]
        public int CodeJobNSI { get; set; }
    }
}
