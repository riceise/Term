using System.ComponentModel.DataAnnotations;


namespace Share.DTOs
{
    public class UploadFileInfoDTO
    {
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

