using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using TG.UBP.Web.Controllers;

namespace TG.UBP.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : UBPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}