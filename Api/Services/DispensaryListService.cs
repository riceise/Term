using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model.Entities.UploadedFile;
using Api.Repositories;

namespace Api.Services
{
    public class DispensaryListService : IDispensaryListService
    {
        private readonly IDispensaryListRepository _repository;

        public DispensaryListService(IDispensaryListRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<DispensaryListResult>> ProcessDispensaryListAsync(int uploadFileInfId)
        {
            var spiski = await _repository.GetSpiskiAsync(uploadFileInfId);
            var results = new List<DispensaryListResult>();

            foreach (var entry in spiski)
            {
                var result = new DispensaryListResult
                {
                    SpiskiNaDnFromMoId = entry.Id,
                    SourceMOCode = entry.N_reest,
                    SourceMOName = await _repository.GetMedicalCompanyShortNameAsync(entry.N_reest.ToString()),
                    LastName = entry.LastName,
                    Name = entry.Name,
                    Patronymic = entry.Patronymic,
                    BirthDay = entry.BirthDay,
                    Snils = entry.Snils,
                    Period = entry.Period,
                    Organization = entry.Organizaciya,
                    ProcessingDate = DateTime.Now
                };

                var zapExists = await _repository.CheckIfExistsInZapAsync(entry.Snils);
                if (zapExists)
                {
                    result.DispensaryRegistrationStatus = "Состоит на ДН";
                    result.DateLastDD = await _repository.GetZapDateDnAsync(entry.Snils);
                    result.DispensaryGroup = await _repository.GetDispensaryGroupAsync(entry.Snils);
                    var observations = await _repository.GetDispensaryObservationsAsync(entry.Snils);
                    if (observations.Any())
                    {
                        var observation = observations.First();
                        result.RegisteredMOCode = int.Parse(observation.LpuType);
                        result.RegisteredMOName = await _repository.GetMedicalCompanyShortNameAsync(observation.LpuType);
                        result.AttachmentMOCode = int.Parse(observation.LpuType);
                        result.AttachmentMOName = await _repository.GetMedicalCompanyShortNameAsync(observation.LpuType);
                        
                        if (string.IsNullOrEmpty(result.AttachmentMOName))
                        {
                            result.AttachmentMOName = "not specified";
                        }
                    }
                    else
                    {
                        result.AttachmentMOName = "not specified";
                    }
                }
                else
                {
                    result.DispensaryRegistrationStatus = "Не состоит на ДН";
                }

                results.Add(result);
            }

            await _repository.SaveDispensaryListResultsAsync(results);
            return results;
        }
        
        public async Task<IEnumerable<DispensaryListResult>> GetDispensaryListResultsAsync(int uploadFileInfId)
        {
            return await _repository.GetDispensaryListResultsByFileIdAsync(uploadFileInfId);
        }

        public async Task<byte[]> GenerateExcelFileAsync(int uploadFileInfId)
        {
            return await _repository.GenerateExcelFileAsync(uploadFileInfId);
        }
    }
}

