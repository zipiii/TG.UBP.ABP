using System.Collections.Generic;
using Abp.Dependency;
using Abp.RealTime;

namespace TG.UBP.Authorization.Users
{
    public interface IUserLogoutInformer
    {
        void InformClients(IReadOnlyList<IOnlineClient> clients);
    }
}
