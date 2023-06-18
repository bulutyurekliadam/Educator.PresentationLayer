using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.Areas.Member.Controllers
{
    public class MyCourseController : Controller
    {
        [Area("Member")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
