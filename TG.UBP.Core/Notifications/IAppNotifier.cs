using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using TG.UBP.Authorization.Users;
using TG.UBP.MultiTenancy;

namespace TG.UBP.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
