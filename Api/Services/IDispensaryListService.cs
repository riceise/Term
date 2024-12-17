using Data.Model.Entities.UploadedFile;

namespace Api.Services
{
    public interface IDispensaryListService
    {
        Task<IEnumerable<DispensaryListResult>> ProcessDispensaryListAsync(int uploadFileInfId);
        Task<byte[]> GenerateExcelFileAsync(int uploadFileInfId);
    }
}

