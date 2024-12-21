using System.ComponentModel.DataAnnotations;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Invoice
{
    public class Invoice : BaseEntity
    {
        [Display(Name = "Медицинская организация")]
        public int MedicalCompanyId { get; set; }
        // public virtual MedicalCompany.MedicalCompany? MedicalCompany { get; set; }

        [Display(Name = "Дата получения файла реестров-счетов")]
        public DateTime InvDate { get; set; }

        [Display(Name = "Выставленная сумма")]
        public decimal TotalSum { get; set; }
        
        [Display(Name = "Сумма санкций")]
        public decimal SankSum { get; set; }
        
        [Display(Name = "Сумма к оплате")]
        public decimal PaySum { get; set; }
        
        [MaxLength(20)]
        [Display(Name = "Номер счета")]
        public string InvNumber { get; set; } = string.Empty;
        
        [MaxLength(5)]
        [Display(Name = "Версия файла")]
        public string Version { get; set; } = string.Empty;
        
        [Display(Name ="Тип файла")]
        public int InvoiceFileTypeId { get; set; }
        // public virtual InvoiceFileType? InvoiceFileType { get; set; }
    }
}