using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Model.Entities.UploadedFile
{
    public class UploadedFile
    {
        [Key]
        public int Id { get; set; }

        public int Npp { get; set; }

        public string LastName { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Patronymic { get; set; } = string.Empty;

        public DateTime BirthDay { get; set; }

        public string Snils { get; set; } = string.Empty;

        public int N_reest { get; set; }

        public int Period { get; set; }

        public string Organizaciya { get; set; } = string.Empty;
    }

    
}
