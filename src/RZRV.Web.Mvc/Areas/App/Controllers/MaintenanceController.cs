using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using RZRV.Authorization;
using RZRV.Caching;
using RZRV.Web.Areas.App.Models.Maintenance;
using RZRV.Web.Controllers;

namespace RZRV.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Maintenance)]
    public class MaintenanceController : RZRVControllerBase
    {
        private readonly ICachingAppService _cachingAppService;

        public MaintenanceController(ICachingAppService cachingAppService)
        {
            _cachingAppService = cachingAppService;
        }

        public ActionResult Index()
        {
            var model = new MaintenanceViewModel
            {
                Caches = _cachingAppService.GetAllCaches().Items,
                CanClearAllCaches = _cachingAppService.CanClearAllCaches()
            };

            return View(model);
        }
    }
}