using Microsoft.EntityFrameworkCore;
using System;
using TeacherEnglish.Entities;

namespace TeacherEnglish
{
    public class ApplicationContext : DbContext
    {        
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<IrregularVerb> IrregularVerbs => Set<IrregularVerb>();
        public DbSet<BaseEntity> BaseEntities => Set<BaseEntity>();
        public DbSet<User> Users => Set<User>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseEntity>().UseTpcMappingStrategy();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }
    }
}
