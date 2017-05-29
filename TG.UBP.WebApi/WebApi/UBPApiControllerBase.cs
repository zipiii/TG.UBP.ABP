using Abp.WebApi.Controllers;

namespace TG.UBP.WebApi
{
    public abstract class UBPApiControllerBase : AbpApiController
    {
        protected UBPApiControllerBase()
        {
            LocalizationSourceName = UBPConsts.LocalizationSourceName;
        }
    }
}