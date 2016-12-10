using System;
using System.IO;

namespace Fuzzyminds.ResumeAspNet
{
    /// <summary>
    /// This helps makes the json provider testable by moving the static 
    /// things and contexts in here.
    /// </summary>
    public class JsonFileIoProvider : IJsonFileIoProvider
    {
        public string GetFileContents()
        {
            return File.ReadAllText(GetJsonFilePath());
        }

        public void WriteFileContents(string resume)
        {
            if (File.Exists(GetJsonFilePath()))
                File.Delete(GetJsonFilePath());

            File.WriteAllText(GetJsonFilePath(),resume);
        }

        public string GetJsonFilePath()
        {
          return  Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jsonModel.json");
        }
    }
}