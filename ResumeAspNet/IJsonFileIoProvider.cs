namespace Fuzzyminds.ResumeAspNet
{
    public interface IJsonFileIoProvider
    {
        string GetFileContents();
        void WriteFileContents(string jsonResume);
    }
}