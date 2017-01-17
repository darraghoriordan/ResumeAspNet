using System.Threading.Tasks;
using Fuzzyminds.ResumeAspNet.ResumeDto;

namespace Fuzzyminds.ResumeAspNet.Services
{
    public class JsonDocumentResumeService : IResumeService
    {
        private readonly IJsonFileIoProvider _jsonFileIoProvider;
        private ResumeRecord _resumeRecord;

        public JsonDocumentResumeService(IJsonFileIoProvider jsonFileIoProvider)
        {
            _jsonFileIoProvider = jsonFileIoProvider;
        }

        public async Task<ResumeRecord> GetResume()
        {
            if (this._resumeRecord == null)
            {
                var jsonResume = await _jsonFileIoProvider.GetFileContents();
                this._resumeRecord =Newtonsoft.Json.JsonConvert.DeserializeObject<ResumeRecord>(jsonResume);
            }
            return _resumeRecord;
        }
    }
}