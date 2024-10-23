using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using RZRV.Modal.Exporting;
using RZRV.Modal.Dtos;
using RZRV.Dto;
using Abp.Application.Services.Dto;
using RZRV.Authorization;
using Abp.Extensions;
using Abp.Authorization;
using Microsoft.EntityFrameworkCore;
using Abp.UI;
using RZRV.Storage;
using RZRV.Modal.Exporting;

namespace RZRV.Modal
{
    [AbpAuthorize(AppPermissions.Pages_Currencies)]
    public abstract class CurrenciesAppServiceBase : RZRVAppServiceBase, ICurrenciesAppServiceBase
    {
        private readonly IRepository<Currency, Guid> _currencyRepository;
        private readonly ICurrenciesExcelExporter _currenciesExcelExporter;

        public CurrenciesAppServiceBase(IRepository<Currency, Guid> currencyRepository, ICurrenciesExcelExporter currenciesExcelExporter)
        {
            _currencyRepository = currencyRepository;
            _currenciesExcelExporter = currenciesExcelExporter;

        }

        public virtual async Task<PagedResultDto<GetCurrencyForViewDto>> GetAll(GetAllCurrenciesInput input)
        {

            var filteredCurrencies = _currencyRepository.GetAll()
                        .WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false || e.Name.Contains(input.Filter))
                        .WhereIf(!string.IsNullOrWhiteSpace(input.NameFilter), e => e.Name.Contains(input.NameFilter));

            var pagedAndFilteredCurrencies = filteredCurrencies
                .OrderBy(input.Sorting ?? "id asc")
                .PageBy(input);

            var currencies = from o in pagedAndFilteredCurrencies
                             select new
                             {

                                 o.Name,
                                 Id = o.Id
                             };

            var totalCount = await filteredCurrencies.CountAsync();

            var dbList = await currencies.ToListAsync();
            var results = new List<GetCurrencyForViewDto>();

            foreach (var o in dbList)
            {
                var res = new GetCurrencyForViewDto()
                {
                    Currency = new CurrencyDto
                    {

                        Name = o.Name,
                        Id = o.Id,
                    }
                };

                results.Add(res);
            }

            return new PagedResultDto<GetCurrencyForViewDto>(
                totalCount,
                results
            );

        }

        public virtual async Task<GetCurrencyForViewDto> GetCurrencyForView(Guid id)
        {
            var currency = await _currencyRepository.GetAsync(id);

            var output = new GetCurrencyForViewDto { Currency = ObjectMapper.Map<CurrencyDto>(currency) };

            return output;
        }

        [AbpAuthorize(AppPermissions.Pages_Currencies_Edit)]
        public virtual async Task<GetCurrencyForEditOutput> GetCurrencyForEdit(EntityDto<Guid> input)
        {
            var currency = await _currencyRepository.FirstOrDefaultAsync(input.Id);

            var output = new GetCurrencyForEditOutput { Currency = ObjectMapper.Map<CreateOrEditCurrencyDto>(currency) };

            return output;
        }

        public virtual async Task CreateOrEdit(CreateOrEditCurrencyDto input)
        {
            if (input.Id == null)
            {
                await Create(input);
            }
            else
            {
                await Update(input);
            }
        }

        [AbpAuthorize(AppPermissions.Pages_Currencies_Create)]
        protected virtual async Task Create(CreateOrEditCurrencyDto input)
        {
            var currency = ObjectMapper.Map<Currency>(input);

            if (AbpSession.TenantId != null)
            {
                currency.TenantId = (int?)AbpSession.TenantId;
            }

            await _currencyRepository.InsertAsync(currency);

        }

        [AbpAuthorize(AppPermissions.Pages_Currencies_Edit)]
        protected virtual async Task Update(CreateOrEditCurrencyDto input)
        {
            var currency = await _currencyRepository.FirstOrDefaultAsync((Guid)input.Id);
            ObjectMapper.Map(input, currency);

        }

        [AbpAuthorize(AppPermissions.Pages_Currencies_Delete)]
        public virtual async Task Delete(EntityDto<Guid> input)
        {
            await _currencyRepository.DeleteAsync(input.Id);
        }

        public virtual async Task<FileDto> GetCurrenciesToExcel(GetAllCurrenciesForExcelInput input)
        {

            var filteredCurrencies = _currencyRepository.GetAll()
                        .WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false || e.Name.Contains(input.Filter))
                        .WhereIf(!string.IsNullOrWhiteSpace(input.NameFilter), e => e.Name.Contains(input.NameFilter));

            var query = from o in filteredCurrencies
                        select new GetCurrencyForViewDto()
                        {
                            Currency = new CurrencyDto
                            {
                                Name = o.Name,
                                Id = o.Id
                            }
                        };

            var currencyListDtos = await query.ToListAsync();

            return _currenciesExcelExporter.ExportToFile(currencyListDtos);
        }

    }
}