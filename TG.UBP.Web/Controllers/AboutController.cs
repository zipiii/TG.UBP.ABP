using System.Web.Mvc;

namespace TG.UBP.Web.Controllers
{
    public class AboutController : UBPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}