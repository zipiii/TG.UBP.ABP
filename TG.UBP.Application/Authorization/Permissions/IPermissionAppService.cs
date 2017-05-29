using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TG.UBP.Authorization.Permissions.Dto;

namespace TG.UBP.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
