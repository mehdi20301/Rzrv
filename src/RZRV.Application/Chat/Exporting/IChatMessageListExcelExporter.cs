using System.Collections.Generic;
using Abp;
using RZRV.Chat.Dto;
using RZRV.Dto;

namespace RZRV.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
