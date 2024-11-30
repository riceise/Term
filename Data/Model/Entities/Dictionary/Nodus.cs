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
    /// Классификатор Nodus. В НСИ ФФОМС справочник N004
    /// </summary>
    [Table(name: "Noduses", Schema = "dict")]
    [Index(nameof(Code))]
    public class Nodus : BaseEntityforApiV1
    {
        [Display(Name = "Код")]
        public int Code { get; set; } = default!;
        [Column(TypeName = "date")]
        [Display(Name = "Начало")]
        public DateTime BeginDate { get; set; }

        [Display(Name = "Окончание")]
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [MaxLength(5)]
        [Display(Name = "Обозначение N для диагноза")]
        public string NCode { get; set; } = string.Empty;

        [MaxLength(500)]
        [Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Id диагноза")]
        public int DiagnosisId { get; set; }
        public virtual Diagnosis? Diagnosis { get; set; }
    }
}
