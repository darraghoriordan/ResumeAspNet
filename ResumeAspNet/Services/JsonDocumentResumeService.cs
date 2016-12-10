using Fuzzyminds.ResumeAspNet.ResumeDto;
using Newtonsoft.Json;

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

        public void WriteResume(ResumeRecord resume)
        {
            _jsonFileIoProvider.WriteFileContents(Newtonsoft.Json.JsonConvert.SerializeObject(resume,
                Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                }));
        }

        public ResumeRecord GetResume()
        {
            if (this._resumeRecord == null)
            {
                var jsonResume = _jsonFileIoProvider.GetFileContents();
                this._resumeRecord = Newtonsoft.Json.JsonConvert.DeserializeObject<ResumeRecord>(jsonResume);
            }
            return _resumeRecord;
        }
    }
}