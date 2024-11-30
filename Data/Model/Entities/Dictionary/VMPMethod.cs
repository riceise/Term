using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    /// Классификатор методов ВМП. В НСИ ФФОМС справочник V019
    /// </summary>
    [Table(name: "VMPMethods", Schema = "dict")]
    [Index(nameof(Code))]
    public class VMPMethod : BaseEntityforApiV1
    {
        [MaxLength(50)]
        [Display(Name = "Код")]
        public string Code { get; set; } = string.Empty;
        [Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Коды диагнозов МКБ для данного метода")]
        public string DS { get; set; } = string.Empty;
        [Display(Name = "Код вида ВМП")]
        public int VidVMPId { get; set; }
        public virtual VidVMP? VidVMP { get; set; }
        [Display(Name = "Номер группы ВМП")]
        public string HGR { get; set; } = string.Empty;
        [Display(Name = "Модель пациента для методов")]
        public string HMODP { get; set; } = string.Empty;
        [Display(Name = "Идентификатор модели пациента для данного метода")]
        public int PatientVMPModelId { get; set; }
        public virtual PatientVMPModel? PatientVMPModel { get; set; }

        [Column(TypeName = "date")]
        public DateTime BeginDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

    }
}
