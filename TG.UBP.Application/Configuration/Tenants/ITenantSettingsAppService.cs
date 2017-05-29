using System.Threading.Tasks;
using Abp.Application.Services;
using TG.UBP.Configuration.Tenants.Dto;

namespace TG.UBP.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
