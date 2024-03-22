using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FactAngular.Controllers
{
    public abstract class FactAngularControllerBase: AbpController
    {
        protected FactAngularControllerBase()
        {
            LocalizationSourceName = FactAngularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
