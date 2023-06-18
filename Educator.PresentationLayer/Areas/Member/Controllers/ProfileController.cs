using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
