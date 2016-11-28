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
        public DbSet<AwardRecord> AwardRecords { get; set; }
        public DbSet<CompanyRecord> CompanyRecords { get; set; }
        public DbSet<CourseRecord> CourseRecords { get; set; }
        public DbSet<EducationRecord> EducationRecords { get; set; }
        public DbSet<InterestRecord> InterestRecords { get; set; }
        public DbSet<PhoneNumberRecord> PhoneNumberRecords { get; set; }
        public DbSet<PositionRecord> PositionRecords { get; set; }
        public DbSet<RecommendationRecord> RecommendationRecords { get; set; }
        public DbSet<ResumeRecord> ResumeRecords { get; set; }
        public DbSet<SkillRecord> SkillRecords { get; set; }

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