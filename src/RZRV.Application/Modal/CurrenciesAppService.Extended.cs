using Abp.Domain.Repositories;
using RZRV.Modal.Exporting;
using RZRV.Authorization;
using Abp.Authorization;
using RZRV.Storage;
using System;

namespace RZRV.Modal
{
    [AbpAuthorize(AppPermissions.Pages_Currencies)]
    public class CurrenciesAppService : CurrenciesAppServiceBase, ICurrenciesAppService
    {
        public CurrenciesAppService(IRepository<Currency, Guid> currencyRepository, ICurrenciesExcelExporter currenciesExcelExporter)
        : base(currencyRepository, currenciesExcelExporter
        )
        {
        }

        // Write your custom code here. 
        // ASP.NET Zero Power Tools will not overwrite this class when you regenerate the related entity.
    }
}