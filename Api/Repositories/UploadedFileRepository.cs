using Data;
using Data.Model.Entities.UploadedFile;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class UploadedFileRepository : IUploadedFileRepository
    {
        private readonly TFOMSContext _context;

        public UploadedFileRepository(TFOMSContext context)
        {
            _context = context;
        }

        public async Task AddUploadedFilesAsync(IEnumerable<UploadedFile> files)
        {
            await _context.Set<UploadedFile>().AddRangeAsync(files);
            await _context.SaveChangesAsync();
        }
        public async Task<UploadedFile> GetByNReestAsync(int nReest)
        {
            return await _context.UploadedFiles.FirstOrDefaultAsync(f => f.N_reest == nReest);
        }

        public async Task<UploadedFile> GetByIdAsync(int id)
        {
            return await _context.UploadedFiles.FindAsync(id);
        }

        public async Task<IEnumerable<UploadedFile>> GetByLastNameAsync(string lastName)
        {
            return await _context.UploadedFiles
                .Where(f => f.LastName.Contains(lastName))
                .ToListAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var file = await GetByIdAsync(id);
            if (file != null)
            {
                _context.UploadedFiles.Remove(file);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(UploadedFile file)
        {
            _context.UploadedFiles.Update(file);
            await _context.SaveChangesAsync();
        }

        public async Task AddAsync(UploadedFile file)
        {
            await _context.UploadedFiles.AddAsync(file);
            await _context.SaveChangesAsync();
        }
    }
}
