using System.Threading.Tasks;
using Abp.Configuration;

namespace TG.UBP.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
