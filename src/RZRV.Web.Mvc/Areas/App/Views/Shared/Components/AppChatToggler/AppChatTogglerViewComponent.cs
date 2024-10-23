using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RZRV.Web.Areas.App.Models.Layout;
using RZRV.Web.Views;

namespace RZRV.Web.Areas.App.Views.Shared.Components.AppChatToggler
{
    public class AppChatTogglerViewComponent : RZRVViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-chat-2 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new ChatTogglerViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
