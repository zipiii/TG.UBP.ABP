﻿using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using TG.UBP.Authorization;
using TG.UBP.Notifications;
using TG.UBP.Web.Controllers;

namespace TG.UBP.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class NotificationsController : UBPControllerBase
    {
        private readonly INotificationAppService _notificationApp;

        public NotificationsController(INotificationAppService notificationApp)
        {
            _notificationApp = notificationApp;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<PartialViewResult> SettingsModal()
        {
            var notificationSettings = await _notificationApp.GetNotificationSettings();
            return PartialView("_SettingsModal", notificationSettings);
        }
    }
}