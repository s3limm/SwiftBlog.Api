using Microsoft.EntityFrameworkCore;
using SwiftBlog.Api.Core.Domain;
using SwiftBlog.Api.Persistance.Configuration;
using SwiftBlog.Api.Persistance.Configurations;

namespace SwiftBlog.Api.Persistance.Context
{
    public class SwiftAppContext : DbContext
    {
        public SwiftAppContext()
        {

        }

        public SwiftAppContext(DbContextOptions<SwiftAppContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                     optionsBuilder.UseSqlServer(
                            "Server=.\\SQLEXPRESS;Database=SwiftAppApiDb;Trusted_Connection=True;TrustServerCertificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
        }

        public DbSet<AppRole> Roles { get; set; }   
        public DbSet<AppUser> Users{ get; set; }   
        public DbSet<Blog> Blogs{ get; set; }   
        public DbSet<Category> Categories{ get; set; }   

    }
}
