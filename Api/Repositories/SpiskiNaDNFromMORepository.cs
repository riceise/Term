using Data;
using Data.Model.Entities.UploadedFile;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class SpiskiNaDNFromMORepository : ISpiskiNaDnFromMoRepository
    {
        private readonly TFOMSContext _context;

        public SpiskiNaDNFromMORepository(TFOMSContext context)
        {
            _context = context;
        }
        public async Task AddSpiskiNaDNFromMOStagingAsync(List<SpiskiNaDnFromMoStaging> stagingData)
        {
            await _context.SpiskiNaDnFromMoStaging.AddRangeAsync(stagingData);
            await _context.SaveChangesAsync();
        }
        
        public async Task<List<SpiskiNaDnFromMoStaging>> GetSpiskiNaDNFromMOStagingAsync()
        {
            return await _context.SpiskiNaDnFromMoStaging.ToListAsync();
        }
        public async Task RemoveSpiskiNaDNFromMOStagingAsync(List<SpiskiNaDnFromMoStaging> stagingData)
        {
            _context.SpiskiNaDnFromMoStaging.RemoveRange(stagingData);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<UploadFileInf>> GetAllFilesAsync()
        {
            return await _context.Set<UploadFileInf>().ToListAsync();
        }
        
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        
        public async Task AddUploadFileInfoAsync(UploadFileInf uploadFileInf)
        {
            _context.UploadFileInfs.Add(uploadFileInf);
            await _context.SaveChangesAsync();
        }
        public async Task AddSpiskiNaDNFromMOsAsync(IEnumerable<SpiskiNaDNFromMO> files)
        {
            await _context.Set<SpiskiNaDNFromMO>().AddRangeAsync(files);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<SpiskiNaDNFromMO>> GetByNReestAsync(int nReest)
        {
            return await _context.SpiskiNaDNFromMO
                .Where(file => file.N_reest == nReest)
                .ToListAsync(); 
        }
        
        public async Task<SpiskiNaDNFromMO> GetByIdAsync(int id)
        {
            return await _context.SpiskiNaDNFromMO.FindAsync(id);
        }

        public async Task<IEnumerable<SpiskiNaDNFromMO>> GetByLastNameAsync(string lastName)
        {
            return await _context.SpiskiNaDNFromMO
                .Where(f => f.LastName.Contains(lastName))
                .ToListAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var file = await GetByIdAsync(id);
            if (file != null)
            {
                _context.SpiskiNaDNFromMO.Remove(file);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(SpiskiNaDNFromMO file)
        {
            _context.SpiskiNaDNFromMO.Update(file);
            await _context.SaveChangesAsync();
        }

        public async Task AddAsync(SpiskiNaDNFromMO file)
        {
            await _context.SpiskiNaDNFromMO.AddAsync(file);
            await _context.SaveChangesAsync();
        }
        
        public async Task<UploadFileInf> GetUploadFileInfoByIdAsync(int id)
        {
            return await _context.UploadFileInfs.FindAsync(id);
        }
        
        public async Task<List<SpiskiNaDNFromMO>> GetByUploadFileIdAsync(int uploadFileId)
        {
            return await _context.SpiskiNaDNFromMO
                .Where(s => s.UploadFileInfId == uploadFileId)
                .ToListAsync();
        }
    }
}
