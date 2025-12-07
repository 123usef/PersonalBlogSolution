using Microsoft.EntityFrameworkCore;
using PersonalBlog.Models;
using System.Reflection;

namespace PersonalBlog.Context
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////fluent Api
            //modelBuilder.Entity<Post>()
            //    .Property(p => p.LikeCount)
            //    .HasDefaultValue(0)
            //    .HasMaxLength(100);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public DbSet<Post> posts { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
