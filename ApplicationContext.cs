using Microsoft.EntityFrameworkCore;
using TeacherEnglish.Entities;

namespace TeacherEnglish
{
    public class ApplicationContext : DbContext
    {
        public DbSet<IrregularVerb> IrregularVerbs => Set<IrregularVerb>();
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }
    }
}
