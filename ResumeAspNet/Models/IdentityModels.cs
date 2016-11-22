using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Fuzzyminds.ResumeAspNet.ResumeDto;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Fuzzyminds.ResumeAspNet.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

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
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
      
    }

    public static class DbSetExtensions
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            dbSet.RemoveRange(dbSet);
        }
    }
}