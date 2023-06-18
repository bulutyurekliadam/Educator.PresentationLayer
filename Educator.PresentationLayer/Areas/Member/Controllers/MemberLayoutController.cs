using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.Areas.Member.Controllers
{
    public class MemberLayoutController : Controller
    {
        [Area("Member")]
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult MemberSideBarPartial()
        {
            return PartialView();
        }

    }
}
