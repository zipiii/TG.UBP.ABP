using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using TG.UBP.Authorization;
using TG.UBP.Web.Controllers;

namespace TG.UBP.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : UBPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}