using System;
using Abp.Application.Services.Dto;

namespace RZRV.Modal.Dtos
{
    public abstract class CurrencyDtoBase : EntityDto<Guid>
    {
        public string Name { get; set; }

    }
}