using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace xyz.Controllers
{
    public abstract class xyzControllerBase: AbpController
    {
        protected xyzControllerBase()
        {
            LocalizationSourceName = xyzConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
