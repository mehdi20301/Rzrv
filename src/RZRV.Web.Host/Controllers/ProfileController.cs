using Abp.AspNetCore.Mvc.Authorization;
using RZRV.Authorization.Users.Profile;
using RZRV.Graphics;
using RZRV.Storage;

namespace RZRV.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(
            ITempFileCacheManager tempFileCacheManager,
            IProfileAppService profileAppService,
            IImageValidator imageValidator) :
            base(tempFileCacheManager, profileAppService, imageValidator)
        {
        }
    }
}