using Abp.Application.Services.Dto;
using System;

namespace RZRV.Modal.Dtos
{
    public abstract class GetAllCurrenciesInputBase : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }

        public string NameFilter { get; set; }

    }
}