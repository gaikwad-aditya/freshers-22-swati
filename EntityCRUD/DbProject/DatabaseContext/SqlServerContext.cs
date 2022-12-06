using Microsoft.EntityFrameworkCore;
using DbProject.Models;

namespace DbProject.DatabaseContext
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> dbContextOptions) : base(dbContextOptions)
        {

        } 
        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(s =>s.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
