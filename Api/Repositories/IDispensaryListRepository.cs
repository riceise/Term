using Data.Model;
using Data.Model.Entities.UploadedFile;


namespace Api.Repositories
{
    public interface IDispensaryListRepository
    {
        Task<IEnumerable<SpiskiNaDNFromMO>> GetSpiskiAsync(int uploadFileInfId);
        Task<string> GetMedicalCompanyShortNameAsync(string code);
        Task<bool> CheckIfExistsInZapAsync(string snils);
        Task<DateTime?> GetZapDateDnAsync(string snils);
        Task<string?> GetDispensaryGroupAsync(string snils);
        Task<IEnumerable<DispensaryObservation>> GetDispensaryObservationsAsync(string snils);
        Task SaveDispensaryListResultsAsync(IEnumerable<DispensaryListResult> results);
        Task<IEnumerable<DispensaryListResult>> GetDispensaryListResultsAsync(int uploadFileInfId);
        Task<byte[]> GenerateExcelFileAsync(int uploadFileInfId);
        Task<IEnumerable<DispensaryListResult>> GetDispensaryListResultsByFileIdAsync(int uploadFileInfId);

    }
}

