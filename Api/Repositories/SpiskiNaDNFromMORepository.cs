using Data;
using Data.Model.Entities.UploadedFile;
using Microsoft.EntityFrameworkCore;
using Share.DTOs;

namespace Api.Repositories
{
    public class SpiskiNaDDFromMORepository : ISpiskiNaDDFromMORepository
    {
        private readonly TFOMSContext _context;

        public SpiskiNaDDFromMORepository(TFOMSContext context)
        {
            _context = context;
        }

        public async Task AddSpiskiNaDDFromMOAsync(List<SpiskiNaDDFromMO> stagingData)
        {
            await _context.SpiskiNaDDFromMO.AddRangeAsync(stagingData);
            await _context.SaveChangesAsync();
        }
        
        
        public async Task<List<SpiskiNaDDFromMO>> GetSpiskiNaDDFromMOSAsync()
        {
            return await _context.SpiskiNaDDFromMO.ToListAsync();
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
        public async Task AddSpiskiNaDDFromMOsAsync(IEnumerable<SpiskiNaDDFromMO> files)
        {
            await _context.Set<SpiskiNaDDFromMO>().AddRangeAsync(files);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<SpiskiNaDDFromMO>> GetByNReestAsync(int nReest)
        {
            return await _context.SpiskiNaDDFromMO
                .Where(file => file.N_reest == nReest)
                .ToListAsync(); 
        }
        
        public async Task<SpiskiNaDDFromMO> GetByIdAsync(int id)
        {
            return await _context.SpiskiNaDDFromMO.FindAsync(id);
        }

        public async Task<IEnumerable<SpiskiNaDDFromMO>> GetByLastNameAsync(string lastName)
        {
            return await _context.SpiskiNaDDFromMO
                .Where(f => f.LastName.Contains(lastName))
                .ToListAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var file = await GetByIdAsync(id);
            if (file != null)
            {
                _context.SpiskiNaDDFromMO.Remove(file);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(SpiskiNaDDFromMO file)
        {
            _context.SpiskiNaDDFromMO.Update(file);
            await _context.SaveChangesAsync();
        }

        public async Task AddAsync(SpiskiNaDDFromMO file)
        {
            await _context.SpiskiNaDDFromMO.AddAsync(file);
            await _context.SaveChangesAsync();
        }
        
        public async Task<UploadFileInf> GetUploadFileInfoByIdAsync(int id)
        {
            return await _context.UploadFileInfs.FindAsync(id);
        }
        
        public async Task<List<SpiskiNaDDFromMO>> GetByUploadFileIdAsync(int uploadFileId)
        {
            return await _context.SpiskiNaDDFromMO
                .Where(s => s.UploadFileInfId == uploadFileId)
                .ToListAsync();
        }
    }
}
