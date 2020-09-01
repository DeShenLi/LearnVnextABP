using VnextProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace VnextProject.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(VnextProjectEntityFrameworkCoreDbMigrationsModule),
        typeof(VnextProjectApplicationContractsModule)
        )]
    public class VnextProjectDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
