using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор болезней МКБ-10(диагнозов). В НСИ МИНЗДРАВ справочник M001
    /// </summary>
    [Table(name: "Diagnoses", Schema = "dict")]
    [Index(nameof(Code))]
    public class Diagnosis:BaseEntityforApiV1
    {
        [Display(Name = "Код МКБ")]
        public string Code { get; set; }= string.Empty;
        [Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Код родительской записи")]
        public int ParentId { get; set; }
        [Display(Name = "Признак актуальности")]
        public bool IsActual { get; set; }
    }
}
