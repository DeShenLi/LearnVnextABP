using VnextProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace VnextProject.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class VnextProjectController : AbpController
    {
        protected VnextProjectController()
        {
            LocalizationResource = typeof(VnextProjectResource);
        }
    }
}