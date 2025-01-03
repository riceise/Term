using Data.Model.Entities.UploadedFile;
using Share.DTOs;

namespace Api.Services
{
    public interface ISpiskiNaDNFromMOService
    {
        Task<SpiskiNaDNFromMODTO?> GetByIdAsync(int id);
        
        Task<IEnumerable<SpiskiNaDNFromMODTO>> GetByNReestAsync(int nReest);
        
        Task<IEnumerable<SpiskiNaDNFromMODTO>> GetByLastNameAsync(string lastName);

        Task DeleteByIdAsync(int id);
        
        Task UpdateAsync( SpiskiNaDNFromMODTO dto);

        Task RecordUploadFileInfoAsync(UploadFileInfoDTO uploadFileInfoDTO);
        
        Task<IEnumerable<FileDTOView>> GetFileInfoAsync();
        
        Task<int> RecordUploadFileInfoAndReturnIdAsync(UploadFileInfoDTO uploadFileInfoDTO);
        
        Task UpdateUploadFileStatusAsync(int uploadFileId, bool status);

        Task<List<string>> ValidateFileAsync(Stream fileStream);

        Task ProcessFileRowsToStagingAsync(Stream fileStream, int uploadFileId);
        
        Task<List<SpiskiNaDNFromMODTO>> GetByUploadFileIdAsync(int uploadFileId);

    }
}