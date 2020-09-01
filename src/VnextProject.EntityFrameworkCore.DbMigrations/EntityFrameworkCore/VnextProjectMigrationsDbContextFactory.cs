using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace VnextProject.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class VnextProjectMigrationsDbContextFactory : IDesignTimeDbContextFactory<VnextProjectMigrationsDbContext>
    {
        public VnextProjectMigrationsDbContext CreateDbContext(string[] args)
        {
            VnextProjectEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<VnextProjectMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new VnextProjectMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
