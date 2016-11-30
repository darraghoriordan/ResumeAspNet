using System.Data.Entity;
using Fuzzyminds.ResumeAspNet.ResumeDto;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Fuzzyminds.ResumeAspNet.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        //    Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseAlways<ApplicationDbContext>());
            Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }
        public virtual DbSet<AwardRecord> AwardRecords { get; set; }
        public virtual DbSet<CompanyRecord> CompanyRecords { get; set; }
        public virtual DbSet<CourseRecord> CourseRecords { get; set; }
        public virtual DbSet<EducationRecord> EducationRecords { get; set; }
        public virtual DbSet<InterestRecord> InterestRecords { get; set; }
        public virtual DbSet<PhoneNumberRecord> PhoneNumberRecords { get; set; }
        public virtual DbSet<PositionRecord> PositionRecords { get; set; }
        public virtual DbSet<RecommendationRecord> RecommendationRecords { get; set; }
        public virtual DbSet<ResumeRecord> ResumeRecords { get; set; }
        public virtual DbSet<SkillRecord> SkillRecords { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //   // modelBuilder.HasDefaultSchema("resumeWebApplication");
        //}

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
      
    }
}