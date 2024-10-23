using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using RZRV.Authorization;
using RZRV.DashboardCustomization;
using System.Threading.Tasks;
using RZRV.Web.Areas.App.Startup;

namespace RZRV.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Dashboard)]
    public class HostDashboardController : CustomizableDashboardControllerBase
    {
        public HostDashboardController(
            DashboardViewConfiguration dashboardViewConfiguration,
            IDashboardCustomizationAppService dashboardCustomizationAppService)
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(RZRVDashboardCustomizationConsts.DashboardNames.DefaultHostDashboard);
        }
    }
}