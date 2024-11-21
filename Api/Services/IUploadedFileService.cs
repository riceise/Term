using Share.DTOs;

namespace Api.Services
{
    public interface IUploadedFileService
    {
        Task ProcessSpiskiNaDN(Stream fileStream);
       
        Task<SpiskiNaDNFromMODTO?> GetByIdAsync(int id);
        
        Task<SpiskiNaDNFromMODTO?> GetByNReestAsync(int nReest);
        
        Task<IEnumerable<SpiskiNaDNFromMODTO>> GetByLastNameAsync(string lastName);

        Task DeleteByIdAsync(int id);
        
        Task UpdateAsync(SpiskiNaDNFromMODTO dto);

    }
}