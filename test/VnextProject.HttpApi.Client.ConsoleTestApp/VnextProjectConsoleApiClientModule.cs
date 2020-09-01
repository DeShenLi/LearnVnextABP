using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace VnextProject.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(VnextProjectHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class VnextProjectConsoleApiClientModule : AbpModule
    {
        
    }
}
