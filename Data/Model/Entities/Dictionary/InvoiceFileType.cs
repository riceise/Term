using System.ComponentModel.DataAnnotations;
using Data.Model.Entities.Common;

namespace Data.Model.Entities.Dictionary
{
    public class InvoiceFileType : BaseGUIDEntity
    {
        [MaxLength(10)]
        [Display(Name = "Расширение файла")]
        public string FileExt { get; set; } = string.Empty;

        [MaxLength(10)]
        [Display(Name = "Тип файла (например- xml, zip)")]
        public string FileType { get; set; } = string.Empty;
        
        [MaxLength(250)]
        [Display(Name = "адрес api для обработки данного типа файлов")]
        public string ApiAdress { get; set; } = string.Empty;
    }
}