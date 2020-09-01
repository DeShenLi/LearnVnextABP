using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace VnextProject.Web
{
    [Dependency(ReplaceServices = true)]
    public class VnextProjectBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "VnextProject";
    }
}
