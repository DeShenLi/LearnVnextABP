using Volo.Abp.Modularity;

namespace VnextProject
{
    [DependsOn(
        typeof(VnextProjectApplicationModule),
        typeof(VnextProjectDomainTestModule)
        )]
    public class VnextProjectApplicationTestModule : AbpModule
    {

    }
}