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
                    SpiskiNaDDFromMOId = entry.Id,
                    SourceMOCode = entry.N_reest,
                    SourceMOName = await _repository.GetMedicalCompanyShortNameAsync(entry.N_reest.ToString()),
                    LastName = entry.LastName,
                    Name = entry.Name,
                    Patronymic = entry.Patronymic,
                    BirthDay = entry.BirthDay,
                    Snils = entry.Snils,
                    Period = entry.Period,
                    ProcessingDate = DateTime.Now
                };

                Console.WriteLine($"Снилс в списках: {entry.Snils}");
                
                results.Add(result);
            }

            await _repository.SaveDispensaryListResultsAsync(results);
            return results;
        }

        public async Task<byte[]> GenerateExcelFileAsync(int uploadFileInfId)
        {
            return await _repository.GenerateExcelFileAsync(uploadFileInfId);
        }
    }
}

