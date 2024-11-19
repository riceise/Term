using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Номенклатура медицинских услуг. В НСИ МИНЗДРАВ справочник V001
    /// </summary>
    [Table(name: "MedicalServices", Schema = "dict")]
    [Index(nameof(Code))]
    public class MedicalService:BaseEntityforApiV1
    {
        [Display(Name = "Код услуги")]
        public string Code { get; set; } = string.Empty;
        [Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Признак актуальности")]
        public bool IsActual { get; set; }
        [Display(Name = "Дата упразднения")]
        [Column(TypeName = "date")]
        public DateTime DateOut { get; set; }
    }
}
