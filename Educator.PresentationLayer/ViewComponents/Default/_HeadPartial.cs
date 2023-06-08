using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.ViewComponents.Default
{
    public class _HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
