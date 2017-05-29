using System.Threading.Tasks;
using TG.UBP.Sessions.Dto;

namespace TG.UBP.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
