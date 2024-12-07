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
            public async Task ProcessSpiskiNaDN(Stream fileStream, string fileName, string filePath, int userId)
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

                            int npp;
                            if (!int.TryParse(row.Cell(1).GetString(), out npp))
                            {
                                errors.Add($"Ошибка: Поле '№ п/п' в строке {row.RowNumber()} имеет неверный формат.");
                                continue;
                            }

                            string lastName = row.Cell(2).GetString();
                            if (string.IsNullOrEmpty(lastName))
                            {
                                errors.Add($"Ошибка: Поле 'Фамилия' в строке {row.RowNumber()} обязательно.");
                                continue;
                            }
                            
                            string name = row.Cell(3).GetString();
                            if (string.IsNullOrEmpty(name))
                            {
                                errors.Add($"Ошибка: Поле 'Имя' в строке {row.RowNumber()} обязательно.");
                                continue;
                            }

                            DateTime birthDay;
                            string dateString = row.Cell(5).GetString();
                            if (!DateTime.TryParseExact(dateString,
                                new[] { "dd.MM.yyyy", "dd.MM.yyyy H:mm:ss", "dd.MM.yyyy HH:mm:ss", "dd.MM.yyyy HH:mm" },
                                null, 
                                System.Globalization.DateTimeStyles.None, 
                                out birthDay))
                            {
                                errors.Add($"Ошибка: Поле 'Дата рождения' в строке {row.RowNumber()} имеет неверный формат: '{dateString}'");
                                continue;
                            }

                            string snils = row.Cell(6).GetString();
                            if (string.IsNullOrWhiteSpace(snils))
                            {
                                errors.Add($"Ошибка: Поле 'СНИЛС' в строке {row.RowNumber()} обязательно.");
                                continue;
                            }

                            int n_reest;
                            if (!int.TryParse(row.Cell(7).GetString(), out n_reest) || !Regex.IsMatch(n_reest.ToString(), @"^\d{6}$"))
                            {
                                errors.Add($"Ошибка: Поле '№ реестра' в строке {row.RowNumber()} должно содержать 6 цифр.");
                                continue;
                            }

                            int period;
                            if (!int.TryParse(row.Cell(8).GetString(), out period))
                            {
                                errors.Add($"Ошибка: Поле 'Период' в строке {row.RowNumber()} имеет неверный формат.");
                                continue;
                            }
                            
                            string organizaciya = row.Cell(9).GetString();
                            if (string.IsNullOrEmpty(organizaciya))
                            {
                                errors.Add($"Ошибка: Поле 'Организация' в строке {row.RowNumber()} обязательно.");
                                continue;
                            }

                            var fileDto = new SpiskiNaDNFromMODTO
                            {
                                Npp = npp,
                                LastName = lastName,
                                Name = name,
                                Patronymic = row.Cell(4).GetString(), 
                                BirthDay = birthDay,
                                Snils = snils,
                                N_reest = n_reest,
                                Period = period,
                                Organizaciya = row.Cell(9).GetString()
                            };

                            var validationContext = new ValidationContext(fileDto);
                            var validationResults = new List<ValidationResult>();
                            if (!Validator.TryValidateObject(fileDto, validationContext, validationResults, validateAllProperties: true))
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
                            errors.Add($"Неожиданная ошибка в строке {row.RowNumber()}: {ex.Message}");
                        }
                    }
                    
                }

                if (errors.Any())
                {
                    throw new ValidationException($"Обнаружены ошибки:\n{string.Join("\n", errors)}");
                }

                var fileEntities = SpiskiNaDNFromMOMapper.MapDtoToEntity(files);
                await _repository.AddSpiskiNaDNFromMOsAsync(fileEntities);
            }
            
            public async Task RecordUploadFileInfoAsync(UploadFileInfoDTO uploadFileInfoDTO)
            {
                var uploadFileInfo = SpiskiNaDNFromMOMapper.MapToEntity(uploadFileInfoDTO);
                await _repository.AddUploadFileInfoAsync(uploadFileInfo);
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
