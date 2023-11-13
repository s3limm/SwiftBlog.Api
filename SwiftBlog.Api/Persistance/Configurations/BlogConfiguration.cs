using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Persistance.Configuration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasOne(x => x.Category).WithMany(x => x.Blogs).HasForeignKey(x => x.CategoryId);
        }
    }
}
