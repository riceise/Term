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
    /// Реестр экспертов качества медицинской помощи. В НСИ ФФОМС справочник F042
    /// </summary>
    [Table(name: "ExpertReestrs", Schema = "dict")]
    [Index(nameof(UidExpert))]
    public class ExpertReestr : BaseEntityforApiV1
    {
        [Display(Name = "Уникальный номер эксперта качества медицинской помощи территориального реестра")]
        public string UidExpert { get; set; } = string.Empty;
        [Display(Name = "Реестровый номер записи об эксперте качества медицинской помощи")]
        public string ReestrNumberExpert { get; set; } = string.Empty;
        [Display(Name = "Код эксперта качества медицинской помощи, используемый для идентификации эксперта до 01.09.2021")]
        public string CodeExpert { get; set; } = string.Empty;
        [Display(Name = "Код территории субъекта Российской Федерации, в территориальный реестр которого включен эксперт качества медицинской помощи, по Общероссийскому классификатору территорий муниципальных образований (ОКТМО)")]
        public string OKTMO { get; set; } = string.Empty;
        [Display(Name = "Наименование субъекта Российской Федерации, в территориальный реестр которого включен эксперт качества медицинской помощи, по Общероссийскому классификатору территорий муниципальных образований (ОКТМО)")]
        public string NameSubject { get; set; } = string.Empty;
        [Column(TypeName = "date")]
        [Display(Name = "Дата создания записи об эксперте качества медицинской помощи территориального реестра")]
        public DateTime BeginDateExpert { get; set; }

        [Display(Name = "Дата исключения эксперта качества медицинской помощи из территориального реестра")]
        [Column(TypeName = "date")]
        public DateTime ExcludingDateExpert { get; set; }
        [Display(Name = "Причина исключения эксперта качества медицинской помощи из территориального реестра. Заполняется в соответствии c классификатором причин исключения из реестра ЭКМП (Приложение А R010, атрибут «Kod»)")]
        public int ExcludingExpertId { get; set; }
        public virtual ExcludingExpert? ExcludingExpert { get; set; }
        [Display(Name = "Количество проведенных экспертиз качества медицинской помощи")]
        public int CountExamination { get; set; }
        [Display(Name = "Количество случаев оказания медицинской помощи, в отношении которых проведена экспертиза качества медицинской помощи")]
        public int CountSluch { get; set; }
        [Display(Name = "Количество медицинских организаций, осуществляющих деятельность в сфере обязательного медицинского страхования, оказавших медицинскую помощь, экспертиза качества которой проведена экспертом")]
        public int CountMedicalCompany { get; set; }
        [Display(Name = "Количество заключений эксперта, признанных необоснованными по результатам повторных экспертиз качества медицинской помощи, проведенных территориальным фондом, или в судебном порядке")]
        public int CountIncorrectConclusion { get; set; }
        [Column(TypeName = "date")]
        [Display(Name = "Начало")]
        public DateTime BeginDate { get; set; }

        [Display(Name = "Окончание")]
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }


    }
}
