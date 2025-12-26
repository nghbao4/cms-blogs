using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CMSBlog.Data
{
    public class CMSBlogDBContextFactory : IDesignTimeDbContextFactory<CMSBlogDBContext>
    {
        public CMSBlogDBContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<CMSBlogDBContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            return new CMSBlogDBContext(optionsBuilder.Options);
        }
    }
}
