using Data.Model.Entities.UploadedFile;
using Share.DTOs;


namespace Api.Repositories
{
    public interface ISpiskiNaDDFromMORepository
    {
        Task AddSpiskiNaDDFromMOsAsync(IEnumerable<SpiskiNaDDFromMO> files);
        Task<IEnumerable<SpiskiNaDDFromMO>> GetByNReestAsync(int nReest); 
        Task<SpiskiNaDDFromMO> GetByIdAsync(int id);
        Task<IEnumerable<SpiskiNaDDFromMO>> GetByLastNameAsync(string lastName);
        Task DeleteByIdAsync(int id);
        Task UpdateAsync(SpiskiNaDDFromMO file);
        Task AddAsync(SpiskiNaDDFromMO file);
        Task AddUploadFileInfoAsync(UploadFileInf uploadFileInf);
        Task<IEnumerable<UploadFileInf>> GetAllFilesAsync();
        Task<UploadFileInf> GetUploadFileInfoByIdAsync(int id);

        Task AddSpiskiNaDDFromMOAsync(List<SpiskiNaDDFromMO> stagingData);
        Task<List<SpiskiNaDDFromMO>> GetSpiskiNaDDFromMOSAsync();
        Task SaveChangesAsync();
        Task<List<SpiskiNaDDFromMO>> GetByUploadFileIdAsync(int uploadFileId);




    }
}

