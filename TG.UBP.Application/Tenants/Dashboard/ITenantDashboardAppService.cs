using Abp.Application.Services;
using TG.UBP.Tenants.Dashboard.Dto;

namespace TG.UBP.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
