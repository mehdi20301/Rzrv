using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using RZRV.Authorization;
using RZRV.Configuration;
using RZRV.Web.Areas.App.Models.UiCustomization;
using RZRV.Web.Controllers;

namespace RZRV.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class UiCustomizationController : RZRVControllerBase
    {
        private readonly IUiCustomizationSettingsAppService _uiCustomizationAppService;

        public UiCustomizationController(IUiCustomizationSettingsAppService uiCustomizationAppService)
        {
            _uiCustomizationAppService = uiCustomizationAppService;
        }

        public async Task<ActionResult> Index()
        {
            var model = new UiCustomizationViewModel
            {
                Theme = await SettingManager.GetSettingValueAsync(AppSettings.UiManagement.Theme),
                Settings = await _uiCustomizationAppService.GetUiManagementSettings(),
                HasUiCustomizationPagePermission = await PermissionChecker.IsGrantedAsync(AppPermissions.Pages_Administration_UiCustomization)
            };

            return View(model);
        }
    }
}