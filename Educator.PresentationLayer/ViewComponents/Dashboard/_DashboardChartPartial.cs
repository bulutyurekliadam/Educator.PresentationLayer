using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardChartPartial : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
