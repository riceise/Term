using Data.Model;
using Data.Model.Entities.Dictionary;
using Data.Model.Entities.Invoice;
using Data.Model.Entities.UploadedFile;


namespace Api.Repositories
{
    public interface IDispensaryListRepository
    {
        Task<IEnumerable<SpiskiNaDDFromMO>> GetSpiskiAsync(int uploadFileInfId);
        Task<string> GetMedicalCompanyShortNameAsync(string code);
        Task<bool> CheckIfExistsInZapAsync(string snils);
        Task<DateTime?> GetZapDateDnAsync(string snils);
        Task<string?> GetDispensaryGroupAsync(string snils);
        Task<IEnumerable<DispensaryObservation>> GetDispensaryObservationsAsync(string snils);
        Task SaveDispensaryListResultsAsync(IEnumerable<DispensaryListResult> results);
        Task<IEnumerable<DispensaryListResult>> GetDispensaryListResultsAsync(int uploadFileInfId);
        Task<byte[]> GenerateExcelFileAsync(int uploadFileInfId);
        Task<string> GetInvoiceFileTypeAsync(int invoiceFileTypeId);
        Task<int> GetInvoiceIdFromZAPAsync(string Name, string LastName, DateTime BirthDay, string snils);
        Task<int> GetInvoiceFileTypeId(int InvoceId);
        Task<bool> CheckPersonExistsAsync(string Name, string LastName, DateTime BirthDay, string snils);
    }
}

