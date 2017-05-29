using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TG.UBP.Caching.Dto;

namespace TG.UBP.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
