using Abp.AspNetCore.Mvc.ViewComponents;

namespace RZRV.Web.Public.Views
{
    public abstract class RZRVViewComponent : AbpViewComponent
    {
        protected RZRVViewComponent()
        {
            LocalizationSourceName = RZRVConsts.LocalizationSourceName;
        }
    }
}