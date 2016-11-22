namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class SkillRecord
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AbilityOutOfTen { get; set; }
        public int YearsOfUse { get; set; }

        public int ResumeRecordId { get; set; }
        public virtual ResumeRecord ResumeRecord { get; set; }
    }
}