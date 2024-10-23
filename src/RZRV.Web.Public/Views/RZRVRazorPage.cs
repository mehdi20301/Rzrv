using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace RZRV.Web.Public.Views
{
    public abstract class RZRVRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected RZRVRazorPage()
        {
            LocalizationSourceName = RZRVConsts.LocalizationSourceName;
        }
    }
}
