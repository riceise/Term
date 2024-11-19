using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор Metastasis. В НСИ ФФОМС справочник N005
    /// </summary>
    [Table(name: "Metastasises", Schema = "dict")]
    [Index(nameof(Code))]
    public class Metastasis : DictionaryBaseType<int>
    {
        [MaxLength(5)]
        [Display(Name = "Обозначение M")]
        public string MCode { get; set; } = string.Empty;
        [Display(Name = "Id диагноза")]
        public int DiagnosisId { get; set; }
        public virtual Diagnosis? Diagnosis { get; set; }
    }
}
