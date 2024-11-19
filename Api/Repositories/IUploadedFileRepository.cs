using Data.Model.Entities.UploadedFile;


namespace Api.Repositories
{
    public interface IUploadedFileRepository
    {
        Task AddUploadedFilesAsync(IEnumerable<UploadedFile> files);

    }
}

