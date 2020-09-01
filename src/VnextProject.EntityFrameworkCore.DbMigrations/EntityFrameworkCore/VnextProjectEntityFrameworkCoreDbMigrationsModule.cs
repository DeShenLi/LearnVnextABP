using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace VnextProject.EntityFrameworkCore
{
    [DependsOn(
        typeof(VnextProjectEntityFrameworkCoreModule)
        )]
    public class VnextProjectEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<VnextProjectMigrationsDbContext>();
        }
    }
}
