using Microsoft.AspNetCore.Mvc;
using RZRV.Web.Controllers;

namespace RZRV.Web.Public.Controllers
{
    public class HomeController : RZRVControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}