using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.ViewComponents.Default
{
    public class _ScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()

        {
            return View();
        }
    }
}
