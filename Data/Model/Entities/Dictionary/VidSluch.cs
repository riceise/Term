using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Виды случая. Региональный справочник
    /// </summary>
    [Table(name: "VidSluchs", Schema = "dict")]
    public class VidSluch : DictionaryBaseType<int>
    {
        [Display(Name = "Ключ условия оказания мед помощи")]
        public int UMPId { get; set; }
        public virtual UMP? UMP { get; set; }
        [Display(Name = "Признак посещения")]
        public bool IsPos { get; set; }
        [Display(Name = "Признак обращения")]
        public bool IsObr { get; set; }
        [Display(Name = "Признак центра здоровья")]
        public bool IsCZ { get; set; }
        [Display(Name = "Признак гемодиализа")]
        public bool IsGem { get; set; }
        [Display(Name = "Признак консультативного приема")]
        public bool IsKons { get; set; }
        [Display(Name = "Признак диспансерного приема")]
        public bool IsDisp { get; set; }
        [Display(Name = "Признак реабилитации")]
        public bool IsReab { get; set; }
        [Display(Name = "Признак ВМП")]
        public bool IsVMP { get; set; }
        [Display(Name = "Признак профилактического приема")]
        public bool IsProf { get; set; }
        [Display(Name = "Признак вызова мобильного приема")]
        public bool IsMob { get; set; }
        [Display(Name = "Признак консультативно-диагностического приема")]
        public bool IsConsDiagn { get; set; }
        [Display(Name = "Признак телемедицины")]
        public bool IsTelemed { get; set; }

    }
}
