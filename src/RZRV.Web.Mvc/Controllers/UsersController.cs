using Abp.AspNetCore.Mvc.Authorization;
using RZRV.Authorization;
using RZRV.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace RZRV.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}