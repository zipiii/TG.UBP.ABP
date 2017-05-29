using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace TG.UBP.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
