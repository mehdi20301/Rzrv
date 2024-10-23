using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Abp.Runtime.Session;
using Abp.Timing.Timezone;
using RZRV.DataExporting.Excel.MiniExcel;
using RZRV.Modal.Dtos;
using RZRV.Dto;
using RZRV.Storage;

namespace RZRV.Modal.Exporting
{
    public class CurrenciesExcelExporter : MiniExcelExcelExporterBase, ICurrenciesExcelExporter
    {
        private readonly ITimeZoneConverter _timeZoneConverter;
        private readonly IAbpSession _abpSession;

        public CurrenciesExcelExporter(
            ITimeZoneConverter timeZoneConverter,
            IAbpSession abpSession,
            ITempFileCacheManager tempFileCacheManager) :
    base(tempFileCacheManager)
        {
            _timeZoneConverter = timeZoneConverter;
            _abpSession = abpSession;

        }

        public FileDto ExportToFile(List<GetCurrencyForViewDto> currencies)
        {
            var items = new List<Dictionary<string, object>>();

            return CreateExcelPackage("Currencies.xlsx", items);

        }

    }
}