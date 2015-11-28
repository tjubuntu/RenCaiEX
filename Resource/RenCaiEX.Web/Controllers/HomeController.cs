using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace RenCaiEX.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : RenCaiEXControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}