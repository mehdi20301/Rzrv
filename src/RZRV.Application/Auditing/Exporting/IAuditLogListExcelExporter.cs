using System.Collections.Generic;
using RZRV.Auditing.Dto;
using RZRV.Dto;

namespace RZRV.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
