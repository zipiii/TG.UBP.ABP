using System.Threading.Tasks;
using Abp.Application.Services;
using TG.UBP.Sessions.Dto;

namespace TG.UBP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
