using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RZRV.Web.Areas.App.Models.Layout;
using RZRV.Web.Session;
using RZRV.Web.Views;

namespace RZRV.Web.Areas.App.Views.Shared.Themes.Default.Components.AppDefaultFooter
{
    public class AppDefaultFooterViewComponent : RZRVViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppDefaultFooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
