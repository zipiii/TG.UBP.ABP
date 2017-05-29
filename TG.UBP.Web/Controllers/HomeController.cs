using System.Web.Mvc;

namespace TG.UBP.Web.Controllers
{
    public class HomeController : UBPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}