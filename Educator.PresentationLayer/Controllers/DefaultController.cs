using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
