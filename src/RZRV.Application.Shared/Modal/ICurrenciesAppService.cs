using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RZRV.Modal.Dtos;
using RZRV.Dto;

using System.Collections.Generic;

namespace RZRV.Modal
{
    public interface ICurrenciesAppServiceBase : IApplicationService
    {
        Task<PagedResultDto<GetCurrencyForViewDto>> GetAll(GetAllCurrenciesInput input);

        Task<GetCurrencyForViewDto> GetCurrencyForView(Guid id);

        Task<GetCurrencyForEditOutput> GetCurrencyForEdit(EntityDto<Guid> input);

        Task CreateOrEdit(CreateOrEditCurrencyDto input);

        Task Delete(EntityDto<Guid> input);

        Task<FileDto> GetCurrenciesToExcel(GetAllCurrenciesForExcelInput input);

    }
}