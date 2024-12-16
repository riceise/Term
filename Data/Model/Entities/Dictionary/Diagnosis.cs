using Data.Model.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Model.Entities.Dictionary
{
    public class Diagnosis : BaseEntity
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


