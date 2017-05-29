using Abp.Notifications;
using TG.UBP.Dto;

namespace TG.UBP.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}