namespace Fuzzyminds.ResumeAspNet.Services
{
    public interface IJsonFileIoProvider
    {
        string GetFileContents();
        void WriteFileContents(string jsonResume);
    }
}