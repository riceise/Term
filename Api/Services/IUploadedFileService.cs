
namespace Api.Services
{
    public interface IUploadedFileService
    {
        Task ProcessSpiskiNaDN(Stream fileStream);

    }
}