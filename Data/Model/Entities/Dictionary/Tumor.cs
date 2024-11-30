using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор Tumor. В НСИ ФФОМС справочник N003
    /// </summary>
    [Table(name: "Tumors", Schema = "dict")]
    [Index(nameof(Code))]
    public class Tumor : BaseEntityforApiV1
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
        [Display(Name = "Обозначение Т для диагноза")]
        public string TCode { get; set; } = string.Empty;
        [MaxLength(500)]
        [Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Id диагноза")]
        public int DiagnosisId { get; set; }
        public virtual Diagnosis? Diagnosis { get; set; }
    }
}
