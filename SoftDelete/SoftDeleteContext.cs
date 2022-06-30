using Microsoft.EntityFrameworkCore;
using SoftDelete.Extensions;
using SoftDelete.Models;

namespace SoftDelete
{
    public class SoftDeleteContext:DbContext
    {
        public SoftDeleteContext(DbContextOptions<SoftDeleteContext> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelbuiler)
        {
            modelbuiler.ManageSoftDeleteBehavoir();
            SeedData(modelbuiler);
        }
        private static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new { Id = 1, Name = "Alice", IsDelete = false },
                new { Id = 2, Name = "Bob", IsDelete = false },
                new { Id = 3, Name = "Tom", IsDelete = true }
                );
        }

        public DbSet<Student> Students { get; set; }
    }
}
