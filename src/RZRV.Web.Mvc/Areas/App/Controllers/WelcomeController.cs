using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using RZRV.Web.Controllers;

namespace RZRV.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : RZRVControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}