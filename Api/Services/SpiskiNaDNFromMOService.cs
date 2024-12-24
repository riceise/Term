using ClosedXML.Excel;
using Share.DTOs;
using Api.Repositories;
using Api.Mappers;
using Data.Model.Entities.UploadedFile;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace Api.Services
{
    public class  SpiskiNaDDFromMOService : ISpiskiNaDDFromMOService
    {
        private readonly ISpiskiNaDDFromMORepository _repository;
        
        
        public SpiskiNaDDFromMOService(ISpiskiNaDDFromMORepository repository)
        {
            _repository = repository;
        }
        
        public async Task<IEnumerable<FileDTOView>> GetFileInfoAsync()
        {
            var files = await _repository.GetAllFilesAsync();
            return files.Select(SpiskiNaDDFromMOMapper.MapToDto);

        }
        
        
        public async Task<List<string>> ValidateFileAsync(Stream fileStream)
        {
            var errors = new List<string>();
            var expectedHeaders = new[]
            {
                "npp", "fam", "im", "ot", "dr", "snils", "n_reestr", "period", "organizaciya"
            };

            using (var workbook = new XLWorkbook(fileStream))
            {
                var worksheet = workbook.Worksheet(1);

                // Проверка заголовков
                var headerRow = worksheet.Row(1);
                for (int i = 0; i < expectedHeaders.Length; i++)
                {
                    var actualHeader = headerRow.Cell(i + 1).GetString().Trim();
                    if (!string.Equals(actualHeader, expectedHeaders[i], StringComparison.OrdinalIgnoreCase))
                    {
                        errors.Add($"Ошибка: Ожидаемый заголовок '{expectedHeaders[i]}' в колонке {i + 1}, но найден '{actualHeader}'");
                    }
                }

                if (errors.Any()) 
                {
                    return errors;
                }

                // Проверка строк
                foreach (var row in worksheet.RowsUsed().Skip(1))
                {
                    try
                    {
                        // Проверка "№ п/п"
                        if (!int.TryParse(row.Cell(1).GetString(), out _))
                        {
                            errors.Add($"Ошибка: Поле '№ п/п' в строке {row.RowNumber()} имеет неверный формат.");
                        }

                        // Проверка "Фамилия"
                        string lastName = row.Cell(2).GetString();
                        if (string.IsNullOrEmpty(lastName))
                        {
                            errors.Add($"Ошибка: Поле 'Фамилия' в строке {row.RowNumber()} обязательно.");
                        }

                        // Проверка "Имя"
                        string name = row.Cell(3).GetString();
                        if (string.IsNullOrEmpty(name))
                        {
                            errors.Add($"Ошибка: Поле 'Имя' в строке {row.RowNumber()} обязательно.");
                        }

                        // Проверка "СНИЛС"
                        string snils = row.Cell(6).GetString();
                        if (string.IsNullOrWhiteSpace(snils))
                        {
                            errors.Add($"Ошибка: Поле 'СНИЛС' в строке {row.RowNumber()} обязательно.");
                        }
                        

                        // Проверка "№ реестра"
                        int n_reest;
                        if (!int.TryParse(row.Cell(7).GetString(), out n_reest) || !Regex.IsMatch(n_reest.ToString(), @"^\d{6}$"))
                        {
                            errors.Add($"Ошибка: Поле '№ реестра' в строке {row.RowNumber()} должно содержать 6 цифр.");
                        }

                        // Проверка "Период"
                        int period;
                        if (!int.TryParse(row.Cell(8).GetString(), out period))
                        {
                            errors.Add($"Ошибка: Поле 'Период' в строке {row.RowNumber()} имеет неверный формат.");
                        }

                        // Проверка "Организация"
                        string organizaciya = row.Cell(9).GetString();
                        if (string.IsNullOrEmpty(organizaciya))
                        {
                            errors.Add($"Ошибка: Поле 'Организация' в строке {row.RowNumber()} обязательно.");
                        }
                    }
                    catch (Exception ex)
                    {
                        errors.Add($"Неожиданная ошибка в строке {row.RowNumber()}: {ex.Message}");
                    }
                }
            }

            return errors;
        }
        
        public async Task ProcessFileRowsToStagingAsync(Stream fileStream, int uploadFileId)
        {
            var files = new List<SpiskiNaDDFromMO>(); 
        
            using (var workbook = new XLWorkbook(fileStream))
            {
                var worksheet = workbook.Worksheet(1);
        
                foreach (var row in worksheet.RowsUsed().Skip(1))
                {
                    int npp = int.Parse(row.Cell(1).GetString());
                    string lastName = row.Cell(2).GetString();
                    string name = row.Cell(3).GetString();
                    string snils = row.Cell(6).GetString();
                    int nReest = int.Parse(row.Cell(7).GetString());
                    int period = int.Parse(row.Cell(8).GetString());
                    string organizaciya = row.Cell(9).GetString();
        
                    files.Add(new SpiskiNaDDFromMO
                    {
                        Npp = npp,
                        LastName = lastName,
                        Name = name,
                        Patronymic = row.Cell(4).GetString(),
                        BirthDay = row.Cell(5).GetDateTime(),
                        Snils = snils,
                        N_reest = nReest,
                        Period = period,
                        Organizaciya = organizaciya,
                        UploadFileInfId = uploadFileId
                    });
                }
            }
        
            await _repository.AddSpiskiNaDDFromMOAsync(files);
            await _repository.SaveChangesAsync();
        }
        
        
        public async Task RecordUploadFileInfoAsync(UploadFileInfoDTO uploadFileInfoDTO)
        {
            var uploadFileInfo = SpiskiNaDDFromMOMapper.MapToEntity(uploadFileInfoDTO);
            await _repository.AddUploadFileInfoAsync(uploadFileInfo);
        }
        
        public async Task<int> RecordUploadFileInfoAndReturnIdAsync(UploadFileInfoDTO uploadFileInfoDTO)
        {
            var uploadFileInfo = SpiskiNaDDFromMOMapper.MapToEntity(uploadFileInfoDTO);
            await _repository.AddUploadFileInfoAsync(uploadFileInfo);
            await _repository.SaveChangesAsync();
            Console.WriteLine($"ID присвоенный файлу: {uploadFileInfo.Id}");

            return uploadFileInfo.Id; 
        }
        
        public async Task UpdateUploadFileStatusAsync(int uploadFileId, bool status)
        {
            var fileInfo = await _repository.GetUploadFileInfoByIdAsync(uploadFileId);
            if (fileInfo == null)
            {
                throw new Exception("Запись о загруженном файле не найдена.");
            }

            fileInfo.UploadStatus = status;
            await _repository.SaveChangesAsync();
        }
        
        public async Task<List<SpiskiNaDDFromMODTO>> GetByUploadFileIdAsync(int uploadFileId)
        {
            var entities = await _repository.GetByUploadFileIdAsync(uploadFileId);
            return entities.Select(entity => new SpiskiNaDDFromMODTO
            {
                Id = entity.Id,
                Npp = entity.Npp,
                LastName = entity.LastName,
                Name = entity.Name,
                Patronymic = entity.Patronymic,
                BirthDay = entity.BirthDay,
                Snils = entity.Snils,
                N_reest = entity.N_reest,
                Period = entity.Period,
                Organizaciya = entity.Organizaciya,
            }).ToList();
        }
        public async Task<IEnumerable<SpiskiNaDDFromMODTO>> GetByNReestAsync(int nReest)
        {
            var files = await _repository.GetByNReestAsync(nReest);
            return files.Select(SpiskiNaDDFromMOMapper.MapEntityToDto).ToList();
        }

        public async Task<SpiskiNaDDFromMODTO> GetByIdAsync(int id)
        {
            var item = await _repository.GetByIdAsync(id);
            return SpiskiNaDDFromMOMapper.MapEntityToDto(item);
        }

        public async Task<IEnumerable<SpiskiNaDDFromMODTO>> GetByLastNameAsync(string lastName)
        {
            var files = await _repository.GetByLastNameAsync(lastName);
            return files.Select(SpiskiNaDDFromMOMapper.MapEntityToDto);
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _repository.DeleteByIdAsync(id);
            await _repository.SaveChangesAsync();
        }
        

        public async Task UpdateAsync(SpiskiNaDDFromMODTO dto)
        {
            var entity = await _repository.GetByIdAsync(dto.Id);
            if (entity == null)
            {
                throw new ValidationException("Запись с указанным ID не найдена.");
            }

            entity.Npp = dto.Npp;
            entity.LastName = dto.LastName;
            entity.Name = dto.Name;
            entity.Patronymic = dto.Patronymic;
            entity.BirthDay = dto.BirthDay;
            entity.Snils = dto.Snils;
            entity.N_reest = dto.N_reest;
            entity.Period = dto.Period;
            entity.Organizaciya = dto.Organizaciya;
            
            await _repository.UpdateAsync(entity);
        }
    }
}
