using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RZRV.Web.Areas.App.Models.Layout;
using RZRV.Web.Views;

namespace RZRV.Web.Areas.App.Views.Shared.Components.
    AppQuickThemeSelect
{
    public class AppQuickThemeSelectViewComponent : RZRVViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-interface-7 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new QuickThemeSelectionViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
