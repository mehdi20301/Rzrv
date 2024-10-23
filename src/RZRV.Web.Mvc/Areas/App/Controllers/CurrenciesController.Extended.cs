using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using RZRV.Web.Areas.App.Models.Currencies;
using RZRV.Web.Controllers;
using RZRV.Authorization;
using RZRV.Modal;
using RZRV.Modal.Dtos;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using Abp.BackgroundJobs;

namespace RZRV.Web.Areas.App.Controllers
{
    public class CurrenciesController : CurrenciesControllerBase
    {
        public CurrenciesController(ICurrenciesAppService currenciesAppService)
            : base(currenciesAppService)
        {
        }

        // Write your custom code here. 
        // ASP.NET Zero Power Tools will not overwrite this class when you regenerate the related entity.
    }
}