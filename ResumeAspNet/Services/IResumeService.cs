using System.Threading.Tasks;
using Fuzzyminds.ResumeAspNet.ResumeDto;
namespace Fuzzyminds.ResumeAspNet.Services
{
    public interface IResumeService
    {
        Task<ResumeRecord> GetResume();
    }
}