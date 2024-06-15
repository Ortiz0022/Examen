using Microsoft.EntityFrameworkCore;
using Entities;

namespace Service.MyDbContext
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("MyDatabase");
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Students)
                .WithOne(s => s.Courses);


            modelBuilder.Entity<Major>()
                .HasMany(m => m.Courses)
                .WithOne(c => c.Majors)
                .HasForeignKey(c => c.MajorId);

            modelBuilder.Entity<Course>()
               .HasOne(c => c.Levels)
               .WithMany(l => l.Courses)
               .HasForeignKey(c => c.LevelId);
        }
    }
}