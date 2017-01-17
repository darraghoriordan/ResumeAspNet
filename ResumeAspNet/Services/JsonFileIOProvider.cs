using System;
using System.IO;
using System.Threading.Tasks;

namespace Fuzzyminds.ResumeAspNet.Services
{
    /// <summary>
    /// This helps makes the json provider testable by moving the static 
    /// things and contexts in here.
    /// </summary>
    public class JsonFileIoProvider : IJsonFileIoProvider
    {
        public async Task<string> GetFileContents()
        {
            using (StreamReader sourceReader = File.OpenText(GetJsonFilePath()))
            {
                return await sourceReader.ReadToEndAsync();
            }
        }

        public string GetJsonFilePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jsonModel.json");
        }
    }
}