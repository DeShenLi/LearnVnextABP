using System;
using System.Collections.Generic;
using System.Text;
using VnextProject.Localization;
using Volo.Abp.Application.Services;

namespace VnextProject
{
    /* Inherit your application services from this class.
     */
    public abstract class VnextProjectAppService : ApplicationService
    {
        protected VnextProjectAppService()
        {
            LocalizationResource = typeof(VnextProjectResource);
        }
    }
}
