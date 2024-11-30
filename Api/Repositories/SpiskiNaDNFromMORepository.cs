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
    }
}
