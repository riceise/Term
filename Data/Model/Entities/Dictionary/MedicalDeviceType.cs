using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Telerik.SvgIcons;

namespace Data.Model.Entities.Dictionary
{
    /// <summary>
    ///Виды медицинских изделий. В НСИ МИНЗДРАВ справочник OID 1.2.643.5.1.13.13.11.1079
    /// </summary>
    [Table(name: "MedicalDeviceTypes", Schema = "dict")]
    [Index(nameof(Code))]
    public class MedicalDeviceType : BaseEntityforApiV1
    {
        [Display(Name = "Код изделия")]
        public string Code { get; set; } = string.Empty;
        [Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Признак актуальности")]
        public bool IsActual { get; set; }
        [Display(Name = "Росздравнадзор")]
        public string RZN { get; set; } = string.Empty;
        [Display(Name = "Признак наличия НПА")]
        public bool IsNPA { get; set; }
        [Display(Name = "Родительский узел")]
        public int ParentId { get; set; }
    }
}
