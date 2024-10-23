using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RZRV.Web.Areas.App.Models.Layout;
using RZRV.Web.Session;
using RZRV.Web.Views;

namespace RZRV.Web.Areas.App.Views.Shared.Themes.Theme6.Components.AppTheme6Brand
{
    public class AppTheme6BrandViewComponent : RZRVViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme6BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string skin = "dark-sm")
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
            };

            ViewBag.BrandLogoSkin = skin;

            return View(headerModel);
        }
    }
}
