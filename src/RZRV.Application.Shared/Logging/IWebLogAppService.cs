using Abp.Application.Services;
using RZRV.Dto;
using RZRV.Logging.Dto;

namespace RZRV.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
