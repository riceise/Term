using Data.Model.Entities.UploadedFile;


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

    }
}

