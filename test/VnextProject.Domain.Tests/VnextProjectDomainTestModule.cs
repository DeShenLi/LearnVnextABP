using VnextProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace VnextProject
{
    [DependsOn(
        typeof(VnextProjectEntityFrameworkCoreTestModule)
        )]
    public class VnextProjectDomainTestModule : AbpModule
    {

    }
}