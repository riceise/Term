using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Справочник ОКАТО. В НСИ ФФОМС O002
    /// </summary>
    [Table(name: "OKATOs", Schema = "dict")]
    public class OKATO:DictionaryBaseType<string>
    {
        //// Поле Code будет являться кодом территории
        [MaxLength(3)]
        [Display(Name = "Код района/города")]
        public string RegionCode { get; set; } = string.Empty;
        [MaxLength(3)]
        [Display(Name = "Код РП/сельсовета")]
        public string VillageCounsilCode { get; set; } = string.Empty;
        [MaxLength(3)]
        [Display(Name = "Код сельского населенного пункта")]
        public string VillageCode { get; set; } = string.Empty;
        [MaxLength(1)]
        [Display(Name = "Код раздела")]
        public string SectionCode { get; set; } = string.Empty;
        [MaxLength(80)]
        [Display(Name = "Дополнительные данные")]
        public string AdditionalInfo { get; set; } = string.Empty;
        [Display(Name = "Номер последнего изменения")]
        public decimal ChangeNumber { get; set; }
        [MaxLength(30)]
        [Display(Name = "Тип последнего изменения")]
        public string Status { get; set; } = string.Empty;
        [Display(Name = "Дата утверждения изменения по позиции")]
        public DateTime DateApproval { get; set; }
        [Display(Name = "Дата введения в действие изменения по позиции")]
        public DateTime DateEffective { get; set; }

    }
}
