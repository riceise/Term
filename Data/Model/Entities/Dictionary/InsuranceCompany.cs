using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Model.Entities.Dictionary
{
    [Table(name: "InsuranceCompanies")]
    public class InsuranceCompany:BaseEntityforApiV1
    {
        [MaxLength(6)]
        [Display(Name = "Код СМО")]
        public string Code { get; set; } = string.Empty;
        [Display(Name = "Полное Наименование")]
        public string FullName { get; set; } = string.Empty;
        [MaxLength(250)]
        [Display(Name = "Сокращенное наименование")]
        public string ShortName { get; set; } = string.Empty;
        [MaxLength(20)]
        [Display(Name = "ИНН")]
        public string INN { get; set; } = string.Empty;
        [MaxLength(15)]
        [Display(Name = "ОГРН")]
        public string OGRN { get; set; } = string.Empty;
        [MaxLength(10)]
        [Display(Name = "КПП")]
        public string KPP { get; set; } = string.Empty;
    }
}
