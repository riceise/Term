using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Model.Entities.Common;

//using Telerik.SvgIcons;

namespace Data.Model.Entities.Invoice
{
    /// <summary>
    /// Типы файлов в пакете реестров счетов
    /// </summary>
    [Table(name: "InvoiceFileTypes", Schema = "dict")]
    public class InvoiceFileType : DictionaryBaseType<string>
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
