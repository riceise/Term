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
                var errors = new List<string>();
                var files = new List<SpiskiNaDNFromMODTO>();

                using (var workbook = new XLWorkbook(fileStream))
                {
                    var worksheet = workbook.Worksheet(1);

                    foreach (var row in worksheet.RowsUsed().Skip(1))
                    {
                        try
                        {
                            DateTime birthDay;
                            string dateString = row.Cell(5).GetString();

                            if (!DateTime.TryParseExact(dateString, 
                                new[] { "dd.MM.yyyy", "dd.MM.yyyy H:mm:ss", "dd.MM.yyyy HH:mm:ss", "dd.MM.yyyy HH:mm" }, 
                                null, 
                                System.Globalization.DateTimeStyles.AssumeUniversal, 
                                out birthDay))                    
                            {
                                errors.Add($"Ошибка: Поле 'Дата рождения' в строке {row.RowNumber()} имеет неверный формат: '{dateString}'");
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

                            // Валидируем модель
                            var validationContext = new ValidationContext(fileDto);
                            var validationResults = new List<ValidationResult>();
                            if (!Validator.TryValidateObject(fileDto, validationContext, validationResults, true))
                            {
                                foreach (var validationResult in validationResults)
                                {
                                    errors.Add($"Ошибка: {validationResult.ErrorMessage} в строке {row.RowNumber()}");
                                }
                                continue;
                            }

                            files.Add(fileDto);
                        }
                        catch (Exception ex)
                        {
                            errors.Add($"Ошибка в строке {row.RowNumber()}: {ex.Message}");
                        }
                    }
                }

                // Если есть ошибки, выбросить исключение с их списком
                if (errors.Any())
                {
                    throw new ValidationException($"Обнаружены ошибки:\n{string.Join("\n", errors)}");
                }

                // Если ошибок нет, сохраняем данные
                var fileEntities = UploadedFileMapper.MapDtoToEntity(files);
                await _repository.AddUploadedFilesAsync(fileEntities);
            }
            public async Task<SpiskiNaDNFromMODTO> GetByNReestAsync(int nReest)
            {
                var file = await _repository.GetByNReestAsync(nReest);
                return UploadedFileMapper.MapEntityToDto(file);
            }

            public async Task<SpiskiNaDNFromMODTO> GetByIdAsync(int id)
            {
                var file = await _repository.GetByIdAsync(id);
                return UploadedFileMapper.MapEntityToDto(file);
            }

            public async Task<IEnumerable<SpiskiNaDNFromMODTO>> GetByLastNameAsync(string lastName)
            {
                var files = await _repository.GetByLastNameAsync(lastName);
                return files.Select(UploadedFileMapper.MapEntityToDto);
            }

            public async Task DeleteByIdAsync(int id)
            {
                await _repository.DeleteByIdAsync(id);
            }

            public async Task UpdateAsync(SpiskiNaDNFromMODTO dto)
            {
                var entity = await _repository.GetByIdAsync(dto.N_reest);
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
