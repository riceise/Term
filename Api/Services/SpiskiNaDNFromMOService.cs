using ClosedXML.Excel;
using Share.DTOs;
using Api.Repositories;
using Api.Mappers;
using Data.Model.Entities.UploadedFile;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace Api.Services
{
    public class  SpiskiNaDnFromMoService : ISpiskiNaDNFromMOService
    {
        private readonly ISpiskiNaDnFromMoRepository _repository;
        
        
        public SpiskiNaDnFromMoService(ISpiskiNaDnFromMoRepository repository)
        {
            _repository = repository;
        }
        
        public async Task<IEnumerable<FileDTOView>> GetFileInfoAsync()
        {
            var files = await _repository.GetAllFilesAsync();
            return files.Select(SpiskiNaDNFromMOMapper.MapToDto);

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

                        string dateString = row.Cell(5).GetString();

                        if (!string.IsNullOrWhiteSpace(dateString))
                        {
                            dateString = dateString.Trim(); // Убираем лишние пробелы

                            DateTime birthDay;
                            // Пробуем распознать дату, игнорируя возможное время
                            if (DateTime.TryParse(dateString, out birthDay))
                            {
                                // Приводим дату к формату "dd.MM.yyyy" для проверки и дальнейшего использования
                                string formattedDate = birthDay.ToString("dd.MM.yyyy");

                                // Проверяем, соответствует ли формат ожидаемому
                                if (dateString.Split(' ')[0] != formattedDate) // Сравниваем только часть с датой
                                {
                                    errors.Add($"Ошибка: Поле 'Дата рождения' в строке {row.RowNumber()} имеет неверный формат: '{dateString}'");
                                }
                            }
                            else
                            {
                                errors.Add($"Ошибка: Поле 'Дата рождения' в строке {row.RowNumber()} имеет неверный формат: '{dateString}'");
                            }
                        }
                        else
                        {
                            errors.Add($"Ошибка: Поле 'Дата рождения' в строке {row.RowNumber()} обязательно.");
                        }




                        // Проверка "СНИЛС"
                        string snils = row.Cell(6).GetString();
                        if (string.IsNullOrWhiteSpace(snils))
                        {
                            errors.Add($"Ошибка: Поле 'СНИЛС' в строке {row.RowNumber()} обязательно.");
                        }
                        else
                        {
                            string sanitizedSnils = snils.Replace(" ", "").Replace("-", "");

                            if (sanitizedSnils.Length != 11 || !sanitizedSnils.All(char.IsDigit))
                            {
                                errors.Add($"Ошибка: Поле 'СНИЛС' в строке {row.RowNumber()} должно содержать 11 цифр.");
                            }
                            else if (!System.Text.RegularExpressions.Regex.IsMatch(snils, @"^\d{3}-\d{3}-\d{3} \d{2}$"))
                            {
                                errors.Add($"Ошибка: Поле 'СНИЛС' в строке {row.RowNumber()} должно быть в формате 'xxx-xxx-xxx xx'.");
                            }
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
            var files = new List<SpiskiNaDNFromMO>(); 
        
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
        
                    files.Add(new SpiskiNaDNFromMO
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
        
            await _repository.AddSpiskiNaDNFromMOAsync(files);
            await _repository.SaveChangesAsync();
        }
        
        
        public async Task RecordUploadFileInfoAsync(UploadFileInfoDTO uploadFileInfoDTO)
        {
            var uploadFileInfo = SpiskiNaDNFromMOMapper.MapToEntity(uploadFileInfoDTO);
            await _repository.AddUploadFileInfoAsync(uploadFileInfo);
        }
        
        public async Task<int> RecordUploadFileInfoAndReturnIdAsync(UploadFileInfoDTO uploadFileInfoDTO)
        {
            var uploadFileInfo = SpiskiNaDNFromMOMapper.MapToEntity(uploadFileInfoDTO);
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
        
        public async Task<List<SpiskiNaDNFromMODTO>> GetByUploadFileIdAsync(int uploadFileId)
        {
            var entities = await _repository.GetByUploadFileIdAsync(uploadFileId);
            return entities.Select(entity => new SpiskiNaDNFromMODTO
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
        public async Task<IEnumerable<SpiskiNaDNFromMODTO>> GetByNReestAsync(int nReest)
        {
            var files = await _repository.GetByNReestAsync(nReest);
            return files.Select(SpiskiNaDNFromMOMapper.MapEntityToDto).ToList();
        }

        public async Task<SpiskiNaDNFromMODTO> GetByIdAsync(int id)
        {
            var item = await _repository.GetByIdAsync(id);
            return SpiskiNaDNFromMOMapper.MapEntityToDto(item);
        }

        public async Task<IEnumerable<SpiskiNaDNFromMODTO>> GetByLastNameAsync(string lastName)
        {
            var files = await _repository.GetByLastNameAsync(lastName);
            return files.Select(SpiskiNaDNFromMOMapper.MapEntityToDto);
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _repository.DeleteByIdAsync(id);
        }
        

        public async Task UpdateAsync(SpiskiNaDNFromMODTO dto)
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
