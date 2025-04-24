using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Date
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { Id =1,Title="Went Hiking",Content="Went hiking with Joe",Created= DateTime.Now},
                new DiaryEntry { Id =2,Title="Went Shoping",Content="Went shoping with Joe",Created= DateTime.Now},
                new DiaryEntry { Id =3,Title="Went Running",Content="Went running with Joe",Created= DateTime.Now}
                
                );
        }
    }
}
