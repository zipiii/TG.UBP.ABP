using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using TG.UBP.Web.Areas.Mpa.Models.Common.Modals;
using TG.UBP.Web.Controllers;

namespace TG.UBP.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class CommonController : UBPControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}