using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace RZRV.Modal.Dtos
{
    public abstract class GetCurrencyForEditOutputBase
    {
        public CreateOrEditCurrencyDto Currency { get; set; }

    }
}