using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardCalenderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
