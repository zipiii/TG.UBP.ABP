using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TG.UBP.Authorization.Users.Dto;

namespace TG.UBP.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
