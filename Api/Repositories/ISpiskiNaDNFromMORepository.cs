using Data.Model.Entities.UploadedFile;
using Share.DTOs;


namespace Api.Repositories
{
    public interface ISpiskiNaDnFromMoRepository
    {
        Task AddSpiskiNaDNFromMOsAsync(IEnumerable<SpiskiNaDNFromMO> files);
        Task<IEnumerable<SpiskiNaDNFromMO>> GetByNReestAsync(int nReest); 
        Task<SpiskiNaDNFromMO> GetByIdAsync(int id);
        Task<IEnumerable<SpiskiNaDNFromMO>> GetByLastNameAsync(string lastName);
        Task DeleteByIdAsync(int id);
        Task UpdateAsync(SpiskiNaDNFromMO file);
        Task AddAsync(SpiskiNaDNFromMO file);
        Task AddUploadFileInfoAsync(UploadFileInf uploadFileInf);
        Task<IEnumerable<UploadFileInf>> GetAllFilesAsync(int uploadFileInfId);
        Task<UploadFileInf> GetUploadFileInfoByIdAsync(int id);
        Task AddSpiskiNaDNFromMOStagingAsync(List<SpiskiNaDnFromMoStaging> stagingData);
        Task<List<SpiskiNaDnFromMoStaging>> GetSpiskiNaDNFromMOStagingAsync();
        Task RemoveSpiskiNaDNFromMOStagingAsync(List<SpiskiNaDnFromMoStaging> stagingData);
        Task SaveChangesAsync();




    }
}

