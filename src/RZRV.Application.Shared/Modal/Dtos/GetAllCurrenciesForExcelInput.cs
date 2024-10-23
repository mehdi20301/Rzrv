using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;

namespace RZRV.Modal.Dtos
{
    public abstract class GetAllCurrenciesForExcelInputBase
    {
        public string Filter { get; set; }

        public string NameFilter { get; set; }

    }
}