using System.Threading.Tasks;

namespace Fuzzyminds.ResumeAspNet.Services
{
    public interface IJsonFileIoProvider
    {
        Task<string> GetFileContents();
    }
}