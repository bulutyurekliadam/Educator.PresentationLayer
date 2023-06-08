using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
