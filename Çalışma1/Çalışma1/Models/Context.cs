using Microsoft.EntityFrameworkCore;

namespace Çalışma1.Models
{
    public class Context:DbContext
    {


        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;  database=Çalışma1; integrated security=true; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//flent api ile ilgili 
        {

            modelBuilder.Entity<Student>(entiy =>// bu ilgili kısımda çoklu model veya class üzerinden ilerle
            {
                entiy.HasOne(x => x.Teacher).WithMany(x => x.Students).HasForeignKey(x => x.TeacherID);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
