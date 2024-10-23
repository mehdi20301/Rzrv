using System;
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

namespace RZRV.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Currencies)]
    public abstract class CurrenciesControllerBase : RZRVControllerBase
    {
        private readonly ICurrenciesAppService _currenciesAppService;

        public CurrenciesControllerBase(ICurrenciesAppService currenciesAppService)
        {
            _currenciesAppService = currenciesAppService;

        }

        public ActionResult Index()
        {
            var model = new CurrenciesViewModel
            {
                FilterText = ""
            };

            return View(model);
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Currencies_Create, AppPermissions.Pages_Currencies_Edit)]
        public async Task<ActionResult> CreateOrEdit(Guid? id)
        {
            GetCurrencyForEditOutput getCurrencyForEditOutput;

            if (id.HasValue)
            {
                getCurrencyForEditOutput = await _currenciesAppService.GetCurrencyForEdit(new EntityDto<Guid> { Id = (Guid)id });
            }
            else
            {
                getCurrencyForEditOutput = new GetCurrencyForEditOutput
                {
                    Currency = new CreateOrEditCurrencyDto()
                };
            }

            var viewModel = new CreateOrEditCurrencyViewModel()
            {
                Currency = getCurrencyForEditOutput.Currency,
            };

            return View(viewModel);
        }

        public async Task<ActionResult> ViewCurrency(Guid id)
        {
            var getCurrencyForViewDto = await _currenciesAppService.GetCurrencyForView(id);

            var model = new CurrencyViewModel()
            {
                Currency = getCurrencyForViewDto.Currency
            };

            return View(model);
        }

    }
}