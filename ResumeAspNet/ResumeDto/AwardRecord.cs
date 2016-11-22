namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class AwardRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ResumeRecordId { get; set; }
        public virtual ResumeRecord ResumeRecord { get; set; }
    }
}