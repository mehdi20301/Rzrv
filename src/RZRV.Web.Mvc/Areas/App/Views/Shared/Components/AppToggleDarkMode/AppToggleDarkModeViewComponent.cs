using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RZRV.Web.Areas.App.Models.Layout;
using RZRV.Web.Views;

namespace RZRV.Web.Areas.App.Views.Shared.Components.AppToggleDarkMode
{
    public class AppToggleDarkModeViewComponent : RZRVViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, bool isDarkModeActive)
        {
            return Task.FromResult<IViewComponentResult>(View(new ToggleDarkModeViewModel(cssClass, isDarkModeActive)));
        }
    }
}