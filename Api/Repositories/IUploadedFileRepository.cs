using Data.Model.Entities.UploadedFile;


namespace Api.Repositories
{
    public interface IUploadedFileRepository
    {
        Task AddUploadedFilesAsync(IEnumerable<UploadedFile> files);
        Task<UploadedFile> GetByNReestAsync(int nReest);
        Task<UploadedFile> GetByIdAsync(int id);
        Task<IEnumerable<UploadedFile>> GetByLastNameAsync(string lastName);
        Task DeleteByIdAsync(int id);
        Task UpdateAsync(UploadedFile file);
        Task AddAsync(UploadedFile file);

    }
}

