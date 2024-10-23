using Abp.BackgroundJobs;
using Microsoft.AspNetCore.Authorization;
using RZRV.Storage;

namespace RZRV.Web.Controllers
{
    [Authorize]
    public class CurrenciesController : CurrenciesControllerBase
    {
        public CurrenciesController(ITempFileCacheManager tempFileCacheManager)
            : base(tempFileCacheManager)
        {
        }

        // Write your custom code here. 
        // ASP.NET Zero Power Tools will not overwrite this class when you regenerate the related entity.
    }
}