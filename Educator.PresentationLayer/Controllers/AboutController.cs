using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
