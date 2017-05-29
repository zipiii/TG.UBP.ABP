using System.Threading.Tasks;
using Abp.Application.Services;
using TG.UBP.Configuration.Host.Dto;

namespace TG.UBP.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
