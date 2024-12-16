using Api.Repositories;
using Data;

namespace WebApplication1.Repositories
{
    public class FileProcessingRepository : IFileProcessingRepository
    { 
        private readonly TFOMSContext _context;

        public FileProcessingRepository(TFOMSContext context)
        {
            _context = context;
        }
        
    }
}

