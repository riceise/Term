using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор стадий. В НСИ ФФОМС справочник N002
    /// </summary>
    [Table(name: "Stages", Schema = "dict")]
    [Index(nameof(Code))]
    public class Stage : DictionaryBaseType<int>
    {
        [Display(Name = "Id диагноза")]
        public int DiagnosisId { get; set; }
        public virtual Diagnosis? Diagnosis { get; set; }
    }
}
