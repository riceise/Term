using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Единицы измерения. В НСИ МИНЗДРАВ справочник OID 1.2.643.5.1.13.13.11.1358
    /// </summary>
    [Table(name: "Units", Schema = "dict")]
    [Index(nameof(Code))]
    public class Unit : DictionaryBaseType<int>
    {
        [Display(Name = "Короткое наименование")]
        [MaxLength(100)]
        public string ShortName { get; set; } = string.Empty;
        [Display(Name = "Наименование для печати")]
        [MaxLength(100)]
        public string PrintName { get; set; } = string.Empty;
        [Display(Name = "Размерность")]
        [MaxLength(100)]
        public string Measurement { get; set; } = string.Empty;
        [Display(Name = "Код UCUM")]
        [MaxLength(100)]
        public string UCUMCode { get; set; } = string.Empty;
        [Display(Name = "Коэффициент пересчета")]
        [MaxLength(20)]
        public string Coefficient { get; set; } = string.Empty;
        [Display(Name = "Код единицы измерения для пересчета")]
        public int ConversionId { get; set; }
        [Display(Name = "Единица измерения для пересчета")]
        [MaxLength(100)]
        public string ConversionName { get; set; } = string.Empty;
        [Display(Name = "Код ОКЕИ")]
        [MaxLength(20)]
        public string OKEICode { get; set; } = string.Empty;
    }
}
