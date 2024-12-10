using System.ComponentModel.DataAnnotations;

namespace Data.Model.Entities.UploadedFile
{
    public class UploadFileInf
    {
        
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Id пользователя загрузившего файл")]
        public int UserId { get; set; }

        [Display(Name = "Название файла")] 
        public string FileName { get; set; } = String.Empty;

        [Display(Name = "Расположение файла")] 
        public string FilePath { get; set; } = String.Empty;
        
        [Display(Name = "Дата загрузки")]
        public DateTime UploadDate { get; set; }

        [Display(Name = "Статус загрузки")]
        public Boolean UploadStatus { get; set; }

    }
}
