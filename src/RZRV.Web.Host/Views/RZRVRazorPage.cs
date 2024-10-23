using Abp.AspNetCore.Mvc.Views;

namespace RZRV.Web.Views
{
    public abstract class RZRVRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected RZRVRazorPage()
        {
            LocalizationSourceName = RZRVConsts.LocalizationSourceName;
        }
    }
}
