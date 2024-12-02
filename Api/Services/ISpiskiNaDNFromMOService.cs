using Data.Model.Entities.UploadedFile;
using Share.DTOs;

namespace Api.Services
{
    public interface ISpiskiNaDNFromMOService
    {
        Task ProcessSpiskiNaDN(Stream fileStream);
       
        Task<SpiskiNaDNFromMODTO?> GetByIdAsync(int id);
        
        Task<IEnumerable<SpiskiNaDNFromMODTO>> GetByNReestAsync(int nReest);
        
        Task<IEnumerable<SpiskiNaDNFromMODTO>> GetByLastNameAsync(string lastName);

        Task DeleteByIdAsync(int id);
        
        Task UpdateAsync( SpiskiNaDNFromMODTO dto);

    }
}