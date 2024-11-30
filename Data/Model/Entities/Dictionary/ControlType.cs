using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор видов контроля. В НСИ ФФОМС справочник F006
    /// </summary>
    [Table(name: "ControlTypes", Schema = "dict")]
    [Index(nameof(Code))]
    public class ControlType : BaseEntityforApiV1
    {
        [Display(Name = "Код")]
        public int Code { get; set; } = default!;
        [Column(TypeName = "date")]
        [Display(Name = "Начало")]
        public DateTime BeginDate { get; set; }

        [Display(Name = "Окончание")]
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;

    }
}
