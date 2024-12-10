using Data;
using Data.Model.Entities.UploadedFile;
using Microsoft.EntityFrameworkCore;


namespace Api.Repositories
{
    public class UploadFileRepository
    {
        private readonly TFOMSContext _context;

        public UploadFileRepository(TFOMSContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UploadFileInf>> GetAllFilesAsync(int uploadFileInfId)
        {
            return await _context.Set<UploadFileInf>().ToListAsync();
        }
    }
}

