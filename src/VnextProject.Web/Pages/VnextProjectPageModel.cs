using VnextProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace VnextProject.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class VnextProjectPageModel : AbpPageModel
    {
        protected VnextProjectPageModel()
        {
            LocalizationResourceType = typeof(VnextProjectResource);
        }
    }
}