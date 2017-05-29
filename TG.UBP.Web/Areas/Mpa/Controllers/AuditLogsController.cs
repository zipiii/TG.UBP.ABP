using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;
using TG.UBP.Authorization;
using TG.UBP.Web.Controllers;

namespace TG.UBP.Web.Areas.Mpa.Controllers
{
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : UBPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}