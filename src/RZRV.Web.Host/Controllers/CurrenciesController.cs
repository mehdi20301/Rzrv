using System;
using System.IO;
using System.Linq;
using Abp.IO.Extensions;
using Abp.UI;
using Abp.Web.Models;
using Microsoft.AspNetCore.Authorization;
using RZRV.Storage;

namespace RZRV.Web.Controllers
{
    [Authorize]
    public abstract class CurrenciesControllerBase : RZRVControllerBase
    {
        private readonly ITempFileCacheManager _tempFileCacheManager;

        public CurrenciesControllerBase(ITempFileCacheManager tempFileCacheManager)
        {
            _tempFileCacheManager = tempFileCacheManager;
        }

    }
}