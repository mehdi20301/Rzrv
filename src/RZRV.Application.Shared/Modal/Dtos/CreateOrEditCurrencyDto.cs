using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace RZRV.Modal.Dtos
{
    public abstract class CreateOrEditCurrencyDtoBase : EntityDto<Guid?>
    {

        [StringLength(CurrencyConsts.MaxNameLength, MinimumLength = CurrencyConsts.MinNameLength)]
        public string Name { get; set; }

    }
}