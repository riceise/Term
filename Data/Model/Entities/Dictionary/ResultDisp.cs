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
    /// Классификатор результатов диспансеризации. В НСИ ФФОМС справочник V017
    /// </summary>
    [Table(name: "ResultDisps", Schema = "dict")]
    [Index(nameof(Code))]
    public class ResultDisp : DictionaryBaseType<int>
    {
    }
}
