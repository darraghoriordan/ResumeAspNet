using System.Data.Entity;

namespace Fuzzyminds.ResumeAspNet.Models
{
    public static class DbSetExtensions
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            dbSet.RemoveRange(dbSet);
        }
    }
}