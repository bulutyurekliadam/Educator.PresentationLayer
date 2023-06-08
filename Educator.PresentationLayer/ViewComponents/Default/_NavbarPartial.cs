using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.ViewComponents.Default
{
    public class _NavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
