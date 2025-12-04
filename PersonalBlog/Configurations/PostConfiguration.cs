using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Models;

namespace PersonalBlog.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.CreatedAt)
                .HasDefaultValue(DateTime.Now);
            
            //builder.HasOne<Category>(w => w.category)
            //    .WithMany()
            //    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
