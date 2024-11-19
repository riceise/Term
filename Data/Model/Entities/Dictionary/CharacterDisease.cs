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
    /// Классификатор характеров заболеваний. В НСИ ФФОМС справочник V027
    /// </summary>
    [Table(name: "CharacterDiseases", Schema = "dict")]
    [Index(nameof(Code))]
    public class CharacterDisease:DictionaryBaseType<int>
    {
    }
}
