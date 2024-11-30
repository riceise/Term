using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    ///Пути введения лекарственных препаратов. В НСИ МИНЗДРАВ справочник OID 1.2.643.5.1.13.13.11.1468
    /// </summary>
    [Table(name: "InjectionMethods", Schema = "dict")]
    [Index(nameof(Code))]
    public class InjectionMethod : DictionaryBaseType<int>
    {
        [Display(Name = "Путь введения на английском языке")]
        [MaxLength(350)]
        public string EnglishName { get; set; } = string.Empty;
        [Display(Name = "Родительский узел")]
        public int ParentId { get; set; }

    }
}
