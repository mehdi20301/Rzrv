using System.Collections.Generic;
using RZRV.Modal.Dtos;
using RZRV.Dto;

namespace RZRV.Modal.Exporting
{
    public interface ICurrenciesExcelExporter
    {
        FileDto ExportToFile(List<GetCurrencyForViewDto> currencies);
    }
}