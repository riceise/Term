using Data.Model.Entities.UploadedFile;
using Share.DTOs;

namespace Api.Services
{
    public interface ISpiskiNaDDFromMOService
    {
        Task<SpiskiNaDDFromMODTO?> GetByIdAsync(int id);
        
        Task<IEnumerable<SpiskiNaDDFromMODTO>> GetByNReestAsync(int nReest);
        
        Task<IEnumerable<SpiskiNaDDFromMODTO>> GetByLastNameAsync(string lastName);

        Task DeleteByIdAsync(int id);
        
        Task UpdateAsync( SpiskiNaDDFromMODTO dto);

        Task RecordUploadFileInfoAsync(UploadFileInfoDTO uploadFileInfoDTO);
        
        Task<IEnumerable<FileDTOView>> GetFileInfoAsync();
        
        Task<int> RecordUploadFileInfoAndReturnIdAsync(UploadFileInfoDTO uploadFileInfoDTO);
        
        Task UpdateUploadFileStatusAsync(int uploadFileId, bool status);

        Task<List<string>> ValidateFileAsync(Stream fileStream);

        Task ProcessFileRowsToStagingAsync(Stream fileStream, int uploadFileId);
        
        Task<List<SpiskiNaDDFromMODTO>> GetByUploadFileIdAsync(int uploadFileId);

    }
}