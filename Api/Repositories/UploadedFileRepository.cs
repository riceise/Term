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
    }
}
