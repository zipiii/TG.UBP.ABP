using Abp.Application.Services;
using TG.UBP.Dto;
using TG.UBP.Logging.Dto;

namespace TG.UBP.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
