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
    /// Классификатор целей посещения. В НСИ ФФОМС справочник V025
    /// </summary>
    [Table(name: "VisitPurposes", Schema = "dict")]
    [Index(nameof(Code))]
    public class VisitPurpose:DictionaryBaseType<string>
    {
    }
}
