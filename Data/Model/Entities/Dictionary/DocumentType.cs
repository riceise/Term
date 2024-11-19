using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор типов документов, удостоверяющих личность. В НСИ ФФОМС справочник F011
    /// </summary>
    [Table(name: "DocumentTypes", Schema = "dict")]
    [Index(nameof(Code))]
    public class DocumentType:DictionaryBaseType<int>
    {
        [MaxLength(20)]
        [Display(Name = "Маска серии документа")]
        public string DocSerFormat { get; set; } = string.Empty;
        [MaxLength(20)]
        [Display(Name = "Маска номера документа")]
        public string DocNumberFormat { get; set; } = string.Empty;
    }
}
