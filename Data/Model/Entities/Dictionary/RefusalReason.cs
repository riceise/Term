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
    /// Классификатор причин отказа в оплате медицинской помощи. В НСИ ФФОМС справочник F014
    /// </summary>
    [Table(name: "RefusalReasons", Schema = "dict")]
    [Index(nameof(Code))]
    public class RefusalReason : BaseEntityforApiV1
    {
        [Display(Name = "Код")]
        public int Code { get; set; } = default!;
        [Column(TypeName = "date")]
        [Display(Name = "Начало")]
        public DateTime BeginDate { get; set; }

        [Display(Name = "Окончание")]
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Служебный комментарий")]
        public string Comments { get; set; } = string.Empty;
        [Display(Name = "Код вида контроля, резервное поле")]
        public string CodeTypeControl { get; set; } = string.Empty;
        [Display(Name = "Основание отказа")]
        public string Reason { get; set; } = string.Empty;
        [Display(Name = "Значение коэффициента для определения размера неоплаты или неполной оплаты затрат медицинской организации на оказание медицинской помощи")]
        public decimal CoefNonPayment { get; set; }
        [Display(Name = "Значение коэффициента для определения размера штрафа за неоказание, несвоевременное оказание либо оказание медицинской помощи ненадлежащего качества")]
        public decimal CoefPenalty { get; set; }
        [Display(Name = "Код по форме ПГ")]
        public string CodePD { get; set; } = string.Empty;
    }
}
