using ClosedXML.Excel;
using Share.DTOs;
using Api.Repositories;
using Api.Mappers;
using Data.Model.Entities.UploadedFile;
using System.ComponentModel.DataAnnotations;

namespace Api.Services
{
    public class  UploadedFileService : IUploadedFileService
    {
        private readonly IUploadedFileRepository _repository;

        public UploadedFileService(IUploadedFileRepository repository)
        {
            _repository = repository;
        }

        public async Task ProcessSpiskiNaDN(Stream fileStream)
        {
            var files = new List<SpiskiNaDNFromMODTO>();

            using (var workbook = new XLWorkbook(fileStream))
            {
                var worksheet = workbook.Worksheet(1);

                foreach (var row in worksheet.RowsUsed().Skip(1))
                {
                    DateTime birthDay;
                    string dateString = row.Cell(5).GetString();

                    if (!DateTime.TryParseExact(dateString, 
                        new[] { "dd.MM.yyyy", "dd.MM.yyyy H:mm:ss", "dd.MM.yyyy HH:mm:ss", "dd.MM.yyyy HH:mm" }, 
                        null, 
                        System.Globalization.DateTimeStyles.AssumeUniversal, 
                        out birthDay))                    
                    {
                        Console.WriteLine($"Ошибка: Не удалось распарсить дату '{dateString}' в строке {row.RowNumber()}");
                        continue; 
                    }
                    var fileDto = new SpiskiNaDNFromMODTO
                    {
                        Npp = int.Parse(row.Cell(1).GetString()),
                        LastName = row.Cell(2).GetString(),
                        Name = row.Cell(3).GetString(),
                        Patronymic = row.Cell(4).GetString(),
                        BirthDay = birthDay.ToUniversalTime(),
                        Snils = row.Cell(6).GetString(),
                        N_reest = int.Parse(row.Cell(7).GetString()),
                        Period = int.Parse(row.Cell(8).GetString()),
                        Organizaciya = row.Cell(9).GetString(),
                    }; 
                    
                    files.Add(fileDto);
                }
            }

            var fileEntities = UploadedFileMapper.MapDtoToEntity(files); 

            await _repository.AddUploadedFilesAsync(fileEntities);
        }
    }
}
