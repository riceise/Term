using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model.Entities.Common;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор профилей оказанной мед помощи. В НСИ ФФОМС справочник V002
    /// </summary>
    [Table(name: "MedProfiles", Schema = "dict")]
    [Index(nameof(Code))]
    public class MedProfile: DictionaryBaseType<int>
    {
    }
}
